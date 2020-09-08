using ContactTracingGraph.Configurations;
using ContactTracingGraph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        public IActionResult RetrieveDiagnosis(ODataActionParameters p)
        {
            //var types = ((IEnumerable<string>)parameters["Types"]).ToList();
            //var typeUri = e2r.RetrieveClassTypeUri(types);

            //var type = types[types.Count - 1];
            //type.ID = typeUri.Fragment.Substring(1);

            return Ok(null);
        }
    }
}
