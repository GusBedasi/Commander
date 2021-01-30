using System.Collections.Generic;
using Commander.Models;

namespace Commander.Repository
{
  public class MockCommanderRepository : ICommanderRepository
  {
    List<Command> commands = new List<Command>
    {
        new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Plataform = "Kettle & Pan"},
        new Command{Id = 1, HowTo = "Cut bread", Line = "Get a knife", Plataform = "Knife & chopping board"},
        new Command{Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Plataform = "Kettle & cup"}, 
    };
    public IEnumerable<Command> GetAppCommands()
    {
      return commands;
    }

    public Command GetCommandById(int id)
    {
      return commands[id];
    }
  }
}