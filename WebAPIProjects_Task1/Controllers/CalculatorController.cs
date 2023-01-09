using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIProjects_Task1_Helper;
using WebAPIProjects_Task1.Model;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIProjects_Task1.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/<CalculatorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CalculatorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CalculatorController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return "From Post Action";
        }

        // PUT api/<CalculatorController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "Hi";
        }

        // DELETE api/<CalculatorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost]
        [Route("addtwonumbers")]
        public ActionResult<Response> AddTwoNumbers(Request request)
        {
            ArthimeticCalculator calculator = new ArthimeticCalculator(request.FirstNumber, request.SecondNumber);
            Response response = calculator.AddTwoNumbers();
            return response;
        }

        [HttpPost]
        [Route("subtracttwonumbers")]
        public ActionResult<Response> SubtractTwoNumbers(Request request)
        {
            ArthimeticCalculator calculator = new ArthimeticCalculator(request.FirstNumber, request.SecondNumber);
            Response response = calculator.SubtractTwoNumbers();
            return response;
        }
    }
}
