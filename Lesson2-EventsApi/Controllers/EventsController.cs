using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson2_EventsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET: api/<EventsController>
        [HttpGet]
        public List<Event> Get()
        {
            List<Event> events = new List<Event>()
          {
              new Event() { Id = 1, End=DateTime.Today.AddDays(3),Start=DateTime.Today,Title="new event"},
              new Event()  { Id = 2, End=DateTime.Today.AddDays(4),Start=DateTime.Today,Title="new event2"},
              new Event()  { Id = 3, End=DateTime.Today.AddDays(7),Start=DateTime.Today,Title="new event3"}};
            return events;
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
