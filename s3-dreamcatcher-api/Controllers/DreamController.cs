using Microsoft.AspNetCore.Mvc;
using s3_dreamcatcher_api.ViewModels;
using s3_dreamcatcher_api.logic.Managers;
using s3_dreamcatcher_api.logic.Models;
using AutoMapper;

namespace s3_dreamcatcher_api.Controllers
{
    [ApiController]
    [Route("dreams")]
    public class DreamController : Controller
    {
        private readonly DreamManager _manager;
        private readonly IMapper _mapper;
        public DreamController(DreamManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DreamViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("createdream")]
        public IActionResult AddDream(DreamViewModel dream)
        {
            var id = _manager.Adddream(_mapper.Map<Dream>(dream));
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DreamViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("getalldreams")]
        public IActionResult GetAllDreams(string userid)
        {
            var dreams = _manager.GetAllDreams(userid);
            return Ok(_mapper.Map<List<DreamViewModel>>(dreams));
        }
    }
}
