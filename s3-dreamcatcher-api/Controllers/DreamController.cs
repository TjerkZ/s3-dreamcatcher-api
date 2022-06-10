using Microsoft.AspNetCore.Mvc;
using s3_dreamcatcher_api.ViewModels;

namespace s3_dreamcatcher_api.Controllers
{
    [ApiController]
    [Route("[Dreams]")]
    public class DreamController : Controller
    {
        public DreamController()
        {

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DreamViewModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("CreateEvent")]
        public IActionResult AddDream(DreamViewModel dream)
        {

        }
    }
}
