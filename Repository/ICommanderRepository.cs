using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
  public interface ICommanderRepository
  {
    IEnumerable<Command> GetAppCommands();
    Command GetCommandById(int id);
  }
}