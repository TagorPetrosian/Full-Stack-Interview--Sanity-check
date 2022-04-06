using backend.Models;
using System.Collections.Generic;

namespace backend.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>() 
            {
                new Command() { Id = 0 , HowTo="Boil an Egg", Line="Boil Water", Platform="Pan"},
                new Command() { Id = 1 , HowTo="Boil an Egg1", Line="Boil Water1", Platform="Pan1"},
                new Command() { Id = 2 , HowTo="Boil an Egg2", Line="Boil Water2", Platform="Pan2"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command() { Id = id , HowTo="Boil an Egg", Line="Boil Water", Platform="Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command command)
        {
            throw new System.NotImplementedException();
        }
    }
}