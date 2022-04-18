using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerAPIservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class customersController : ControllerBase
    {
        // GET: api/<customersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Customer", "ID:101101" };
        }

        // GET api/<customersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<customersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<customersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<customersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
