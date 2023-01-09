using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIProjects_Task1_Helper;
using WebAPIProjects_Task1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIProjects_Task1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AsyncCalculatorController : ControllerBase
    {

        [HttpPost]
        [Route("addtwonumbersAsync")]
        public async Task<Response> AddTwoNumbersAsync(Request request)
        {
            ArthimeticCalculator calculator = new ArthimeticCalculator(request.FirstNumber, request.SecondNumber);
            Response response = await calculator.AddTwoNumbersAsync();
            return response;
        }

        [HttpPost]
        [Route("subtracttwonumbersAsync")]
        public async Task<Response> SubtractTwoNumbersAsync(Request request)
        {
            ArthimeticCalculator calculator = new ArthimeticCalculator(request.FirstNumber, request.SecondNumber);
            Response response = await calculator.SubtractTwoNumbersAsync();
            return response;
        }
        // GET: api/<AsyncCalculatorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AsyncCalculatorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AsyncCalculatorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AsyncCalculatorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AsyncCalculatorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
