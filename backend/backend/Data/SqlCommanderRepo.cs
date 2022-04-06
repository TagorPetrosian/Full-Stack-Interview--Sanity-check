using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private CommanderContex _context;

        public SqlCommanderRepo(CommanderContex context)
        {
            _context = context;
        }

        public void CreateCommand(Command command)
        {
            if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
            _context.Commands.Add(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateCommand(Command command)
        {
            return;
        }
    }
}
