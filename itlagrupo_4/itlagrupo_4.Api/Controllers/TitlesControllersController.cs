using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace itlagrupo_4.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesControllersController : ControllerBase
    {
        // GET: api/TitlesControllers
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TitlesControllers/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TitlesControllers
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TitlesControllers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/TitlesControllers/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
