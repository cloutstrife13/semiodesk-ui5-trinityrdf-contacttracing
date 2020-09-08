using ContactTracingGraph.Configurations;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactTracingGraph.Controllers
{
    [ODataRoutePrefix("Place")]
    public class PlaceController : ODataController
    {
        private readonly TrinityRepository<Place> repo;

        public PlaceController(DbContext trinity)
        {
            repo = new TrinityRepository<Place>(trinity.DefaultModel);
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(repo.Read());
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<Place>());

            if (Obj is null)
                return BadRequest();

            return Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<Place>());

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
