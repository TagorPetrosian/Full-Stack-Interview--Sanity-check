using AutoMapper;
using backend.Data;
using backend.Dtos;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandController: ControllerBase
    {
        private readonly ICommanderRepo _repo;
        private readonly IMapper _mapper;

        public CommandController(ICommanderRepo repository, IMapper mapper) 
        {
            _repo = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandList = _repo.GetAllCommands();
            return Ok(_mapper.Map<CommandReadDto>(commandList)); 
        }

        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var item = _repo.GetCommandById(id);
            if(item != null)
            {
                return Ok(_mapper.Map<CommandReadDto>(item));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandCreateDto)
        {
            var commandModel = _mapper.Map<Command>(commandCreateDto);
            _repo.CreateCommand(commandModel);
            _repo.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(commandModel);
            return Ok(commandReadDto);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateCommand(int id, CommandUpdateDto commandUpdateDto)
        {
            var modelFromRepo = _repo.GetCommandById(id);

            if(modelFromRepo == null)
            { 
                return NotFound();
            }
            // data updated
            _mapper.Map(commandUpdateDto, modelFromRepo);
            _repo.UpdateCommand(modelFromRepo);
            _repo.SaveChanges();

            return NoContent();
        }
    }
}