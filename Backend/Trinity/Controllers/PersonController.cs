using ContactTracingGraph.Configurations;
using ContactTracingGraph.Supports;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using ContactTracingGraph.Queries;
using System.Collections.Generic;

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
            return (r.Count < 1) ? (IActionResult) NotFound() : Ok(r[0]);
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
                Person p = repo.Read().Find(p => p.ID == ID);

                if (p != null)
                {
                    // 1. Record current time
                    var timeStampNow = DateTime.Now;

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

                    return Ok("COVID-19 confirmed.");
                }
            }

            return BadRequest();
        }
    }
}
