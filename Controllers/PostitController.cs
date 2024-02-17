using Microsoft.AspNetCore.Mvc;
using Postit_webapp.Models;
using PostitWebAPI.Repositories.Interfaces;

namespace PostitWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostitController : ControllerBase
    {
        public readonly IPostitRepository _postitRepository;

        public PostitController(IPostitRepository postitRepository)
        {
            _postitRepository = postitRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Postit>>> GetAllPostits()
        {
            var response = await _postitRepository.GetAllPostits();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Postit>> AddPostit([FromBody] Postit postit)
        {
            var response = await _postitRepository.AddPostit(postit);
            return Ok(response);
        }

        [HttpPut("update/{Id}")]
        public async Task<ActionResult<Postit>> UpdatePostit([FromBody] Postit postit, Guid Id)
        {
            postit.Id = Id;
            var response = await _postitRepository.UpdatePostit(postit, postit.Id);
            return Ok(response);
        }

        [HttpPut("delete/{Id}")]
        public async Task<ActionResult<Postit>> DeletePostit([FromBody] Postit postit, Guid Id)
        {
            postit.Id = Id;
            var response = await _postitRepository.DeletePostit(postit, postit.Id);
            return Ok(response);
        }
    }
}
