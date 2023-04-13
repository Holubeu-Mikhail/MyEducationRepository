using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepository _repository;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms() 
        {
            Console.WriteLine("--> Getting Platforms...");

            IEnumerable<Platform> platformItem = _repository.GetAll();

            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItem));
        }

        [HttpGet("{id}")]
        public ActionResult<PlatformReadDto> GetPlatforms(int id)
        {
            Console.WriteLine("--> Getting Platform by id...");

            Platform platformItem = _repository.GetById(id);

            if (platformItem != null)
            {
                return Ok(_mapper.Map<PlatformReadDto>(platformItem));
            }

            return NotFound();
        }

        [HttpPost]
        public ActionResult<PlatformReadDto> CreatePlatform([FromBody] PlatformCreateDto platformCreateDto)
        {
            Console.WriteLine("--> Creating Platform...");

            Platform platform = _mapper.Map<Platform>(platformCreateDto);
            _repository.Create(platform);
            _repository.SaveChanges();

            PlatformReadDto platformReadDto = _mapper.Map<PlatformReadDto>(platform);

            return Ok(platformReadDto);
        }
    }
}
