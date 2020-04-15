using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace service1.Api.Controllers
{
  
    [Route("api/[controller]")]
     [ApiController]
     public class GreetingController : ControllerBase
    {
        // GET: api/Value
        [HttpGet]
        public string Get()
        {
            string greeting = string.Empty;
            if (DateTime.Now.Hour < 12)
            {
                greeting = "Good Morning";
            }
            if (DateTime.Now.Hour < 17)
            {
                greeting = "Good Afternoon";
            }
            else
            {
                greeting = "Good Evening";
            }
            greeting = String.Format("{0} Sonu !", greeting);
            return greeting;
        }

        // GET: api/Value/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Value
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Value/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
