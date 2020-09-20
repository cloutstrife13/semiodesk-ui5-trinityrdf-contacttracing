using ContactTracingGraph.Configurations;
using ContactTracingGraph.Supports;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using ContactTracingGraph.Queries;
using System.Collections.Generic;
using System.Linq;

namespace ContactTracingGraph.Controllers
{
    [ODataRoutePrefix("Person")]
    public class PersonController : ODataController
    {
        private readonly TrinityRepository<Person> repo;
        private readonly SparqlQueryManager sqm;

        public PersonController(DbContext trinity)
        {
            repo = new TrinityRepository<Person>(trinity.DefaultModel);
            sqm = new SparqlQueryManager();
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(repo.Read(sqm.GetPersonQuery()));
        }

        [EnableQuery]
        public IActionResult Get(string key)
        {
            List<Person> r = repo.Read(sqm.GetPersonByIdQuery(key));
            return (r.Count < 1) ? (IActionResult) NotFound() : Ok(r.First());
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<Person>());
            return (Obj is null) ? BadRequest() : Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<Person>());
            return (Obj is null) ? NotFound() : Ok(Obj);
        }

        public IActionResult Delete([FromODataUri] string key)
        {
            return repo.Delete(new Uri($"{CRT.Namespace}{key}")) ? (IActionResult)Ok() : NotFound();
        }

        [HttpPost, ODataRoute("SubmitDiagnosis")]
        public IActionResult SubmitDiagnosis(ODataActionParameters parameter)
        {
            string ID = parameter["ID"].ToString();

            if (ID.Length > 0)
            {
                Person p = repo.Read(ID);

                if (p != null)
                {
                    // 1. Record current time
                    DateTime timeStampNow = DateTime.Now;

                    // 2. Instantiate new Diagnosis
                    InfectiousDisease d = new InfectiousDisease($"COVID19_{timeStampNow.ToString("HHmmssddMMyyyy")}");
                    d.Classification = "COVID-19";
                    d.DateDiagnosed = timeStampNow;

                    // 3. Bind the newly created individual to the database
                    d.SetModel(p.Model);
                    d.Commit();
                    
                    // 4. Associate the newly created individual to the desired person
                    p.Diagnosis.Add(d);
                    repo.Update(p);

                    return Ok(d);
                }
            }

            return BadRequest();
        }

        [HttpPost, ODataRoute("RecordEncounter")]
        public IActionResult RecordEncounter(ODataActionParameters parameter)
        {
            string locationId = parameter["LocationId"].ToString();
            List<string> userIds = (parameter["UserIds"] as IEnumerable<string>).ToList();

            if(userIds.Count > 0)
            {
                // 1. Instantiate Encounter and Location
                DateTime timeStampNow = DateTime.Now;
                Encounter e = new Encounter($"ENC_{timeStampNow.ToString("HHmmssddMMyyyy")}");

                // 2. Bind the Encounter instance to the relevant properties
                e.Place = repo.Read<Place>(locationId);
                e.DateEncountered = timeStampNow;
                e.Person = repo.Read<Person>().Where(p => userIds.Contains(p.ID)).ToList();

                // 3. Bind the newly created Encounter instance to the database
                e.SetModel(e.Person.First().Model);
                e.Commit();

                // 4. Associate the people to the new Encounter instance
                e.Person.ForEach(p => {
                    p.Encounter.Add(e);
                    repo.Update(p);
                });

                return Ok(e);
            }

            return BadRequest();
        }   
    }
}
