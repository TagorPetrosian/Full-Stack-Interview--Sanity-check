using backend.Models;
using System.Collections.Generic;

namespace backend.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

        void CreateCommand(Command command);
        void UpdateCommand(Command command);

        bool SaveChanges();
    }
}
