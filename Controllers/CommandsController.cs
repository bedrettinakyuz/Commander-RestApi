using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo repository;
        public CommandsController(ICommanderRepo repository)
        {
            this.repository = repository;

        }
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        //Get api/commands
        [HttpGet]
       public ActionResult <IEnumerable<Command>> GetAllCommands()
       {
           var commandItems = _repository.GettAppCommands();
           return Ok(commandItems);
       }
        //GET api/commands/5
       [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }

    }
    
}