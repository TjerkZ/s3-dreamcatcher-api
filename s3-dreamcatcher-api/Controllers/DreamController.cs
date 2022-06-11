using Microsoft.AspNetCore.Mvc;
using s3_dreamcatcher_api.ViewModels;
using s3_dreamcatcher_api.logic.Managers;
using s3_dreamcatcher_api.logic.Models;

namespace s3_dreamcatcher_api.Controllers
{
    [ApiController]
    [Route("[Dreams]")]
    public class DreamController : Controller
    {
        private readonly DreamManager _manager;
        public DreamController(DreamManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DreamViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("CreateDream")]
        public IActionResult AddDream(DreamViewModel dream)
        {
            _manager.Adddream();
        }
    }
}
