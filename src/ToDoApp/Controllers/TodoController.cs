using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.AppServices.Dtos;
using ToDoApp.AppServices.Interfaces;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoAppService appService;

        public TodoController(ITodoAppService appService)
        {
            this.appService = appService;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<TodoDto> Get([FromBody]TodoFilterDto filter)
        {
            return appService.List(filter);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TodoDto Get(int id)
        {
            return appService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public TodoDto Post([FromBody]TodoDto model)
        {
            return appService.Create(model);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody]TodoDto model)
        {
            return appService.Update(model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return appService.Delete(id);
        }
    }
}
