using ContactTracingGraph.Configurations;
using ContactTracingGraph.Supports;
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

        [EnableQuery]
        public IActionResult Get(string key)
        {
            Place Obj = repo.Read(key);
            return (Obj is null) ? (IActionResult) NotFound() : Ok(Obj);
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<Place>());
            return (Obj is null) ? BadRequest() : Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<Place>());
            return (Obj is null) ? NotFound() : Ok(Obj);
        }

        public IActionResult Delete([FromODataUri] string key)
        {
            return repo.Delete(new Uri($"{CRT.Namespace}{key}")) ? (IActionResult) Ok() : NotFound();
        }
    }
}
