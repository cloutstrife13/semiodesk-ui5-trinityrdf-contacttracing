using ContactTracingGraph.Configurations;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactTracingGraph.Controllers
{
    [ODataRoutePrefix("Encounter")]
    public class EncounterController : ODataController
    {
        private readonly TrinityRepository<Encounter> repo;

        public EncounterController(DbContext trinity)
        {
            repo = new TrinityRepository<Encounter>(trinity.DefaultModel);
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(repo.Read());
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<Encounter>());

            if (Obj is null)
                return BadRequest();

            return Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<Encounter>());

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
    }
}
