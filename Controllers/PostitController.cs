using Microsoft.AspNetCore.Mvc;
using Postit_webapp.Models;

namespace PostitWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostitController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Postit>> GetAllPostits()
        {
            return Ok();
        }
    }
}
