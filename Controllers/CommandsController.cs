using System.Collections.Generic;
using Commander.Models;
using Commander.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
  [Route("api/commands")]
  [ApiController]
  public class CommandsController : ControllerBase
  {
    private ICommanderRepository _repository;

    public CommandsController(ICommanderRepository repository)
    {
      this._repository = repository;
    }

    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {
      IEnumerable<Command> commandsItems = this._repository.GetAppCommands();

      return Ok(commandsItems);
    }

    //GET api/commands/5
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id)
    {
      Command command = this._repository.GetCommandById(id);

      return Ok(command);
    }
 } 
}