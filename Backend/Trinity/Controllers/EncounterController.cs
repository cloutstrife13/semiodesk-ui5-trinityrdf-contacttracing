using ContactTracingGraph.Configurations;
using ContactTracingGraph.Supports;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ContactTracingGraph.Queries;
using System.Linq;

namespace ContactTracingGraph.Controllers
{
    [ODataRoutePrefix("Encounter")]
    public class EncounterController : ODataController
    {
        private readonly TrinityRepository<Encounter> repo;
        private readonly SparqlQueryManager sqm;

        public EncounterController(DbContext trinity) {
            repo = new TrinityRepository<Encounter>(trinity.DefaultModel);
            sqm = new SparqlQueryManager();
        }

        [EnableQuery]
        public IActionResult Get()
        {
            // 1. Get all Encounters
            List<Encounter> resEnc = repo.Read();

            if(resEnc.Count > 0)
            {
                // 2. Get all People by Query
                List<Person> resUsr = repo.Read<Person>(sqm.GetPersonQuery());

                // 3. Substitute resEnc.Person with a subset of resUsr for COVID Health Level
                if(resUsr.Count > 0)
                {
                    resEnc = resEnc.Select(e => {
                        List<Person> people = resUsr.Where(u => e.Person.Select(p => p.ID).Contains(u.ID)).ToList();
                        List<int> health = people.Select(e => e.CovidHealthLevel).ToList();
                        e.Person = people;
                        e.CovidRiskLevel = health.Contains(3) ? 3 : health.Contains(2) ? 2 : 1;
                        return e;
                    }).ToList();
                }
            }

            return Ok(resEnc);
        }

        [EnableQuery]
        public IActionResult Get([FromODataUri] string key)
        {
            // 1. Get Encounter by ID
            Encounter Obj = repo.Read(key);

            if (Obj is null)
                return NotFound();

            // 2. Get all People by Query
            List<Person> resUsr = repo.Read<Person>(sqm.GetPersonQuery());

            // 3. Substitute Obj.Person with a subset of resUsr for COVID Health Level
            if (resUsr.Count > 0)
            {
                List<Person> people = resUsr.Where(u => Obj.Person.Select(p => p.ID).Contains(u.ID)).ToList();
                List<int> health = people.Select(e => e.CovidHealthLevel).ToList();
                Obj.Person = people;
                Obj.CovidRiskLevel = health.Contains(3) ? 3 : health.Contains(2) ? 2 : 1;
            }

            return Ok(Obj);
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<Encounter>());
            return (Obj is null) ? BadRequest() : Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<Encounter>());
            return (Obj is null) ? NotFound() : Ok(Obj);

        }

        public IActionResult Delete([FromODataUri] string key)
        {
            return repo.Delete(new Uri($"{CRT.Namespace}{key}")) ? (IActionResult) Ok() : NotFound();
        }
    }
}
