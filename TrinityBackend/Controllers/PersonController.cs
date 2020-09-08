using ContactTracingGraph.Configurations;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactTracingGraph.Controllers
{
    [ODataRoutePrefix("Person")]
    public class PersonController : ODataController
    {
        private readonly TrinityRepository<Person> repo;

        public PersonController(DbContext trinity)
        {
            repo = new TrinityRepository<Person>(trinity.DefaultModel);
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(repo.Read());
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<Person>());

            if (Obj is null)
                return BadRequest();

            return Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<Person>());

            if (Obj is null)
                return BadRequest();

            return Ok(Obj);
        }

        public IActionResult Delete([FromODataUri] string key)
        {
            if (repo.Delete(new Uri($"{CRT.Namespace}{key}")))
                return Ok();

            return BadRequest();
        }

        [HttpPost, ODataRoute("RetrieveDiagnosis")]
        public IActionResult RetrieveDiagnosis(ODataActionParameters parameter)
        {
            string ID = parameter["ID"].ToString();

            if (ID.Length > 0)
            {
                dynamic p = repo.Read().Find(p => p.ID == ID);

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
                    p.Diagnosis = d;
                    repo.Update(p);

                    return Ok("COVID-19 confirmed.");
                }
            }

            return BadRequest();
        }
    }
}
