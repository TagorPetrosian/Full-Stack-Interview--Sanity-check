using AutoMapper;
using backend.Dtos;
using backend.Models;

namespace backend.Profiles
{
    public class CommandsProfile: Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();

        }
    }
}
