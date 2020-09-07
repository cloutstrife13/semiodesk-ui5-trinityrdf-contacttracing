using CWA_Graph.Configurations;
using CWA_Graph.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CWA_Graph.Controllers
{
    public class UserController : ODataController
    {
        private readonly TrinityRepository<User> repo;

        public UserController(DbContext trinity)
        {
            repo = new TrinityRepository<User>(trinity.DefaultModel);
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(repo.Read());
        }

        public IActionResult Post([FromBody]dynamic Obj)
        {
            Obj = repo.Create(Obj.ToObject<User>());

            if (Obj is null)
                return BadRequest();

            return Ok(Obj);
        }

        public IActionResult Put([FromBody] dynamic Obj, [FromODataUri] string key)
        {
            Obj.ID = key;
            Obj = repo.Update(Obj.ToObject<User>());

            if (Obj is null)
                return BadRequest();

            return Ok(Obj);
        }

        public IActionResult Delete([FromODataUri] string key)
        {
            if (repo.Delete(new Uri($"{CWA.Namespace}{key}")))
                return Ok();

            return BadRequest();
        }
    }
}
