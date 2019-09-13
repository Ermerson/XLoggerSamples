using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using XLogger.Adapters.Console;

namespace SampleXLogger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConsoleLogger _consoleLogger;

        public ValuesController(IConsoleLogger consoleLogger)
        {
            _consoleLogger = consoleLogger;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
             System.Console.WriteLine("Teste novamente");
            _consoleLogger.Information("Logger gerado");
            _consoleLogger.Error("Opps! An Error has occurred");

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
