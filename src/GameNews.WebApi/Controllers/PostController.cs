using GameNews.Infrastructure.DataTransferObjects;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameNews.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController (IMediator mediatr)
        {
            _mediator = mediatr;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllPostsQuery();
            List<PostEntity> result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetPostByIdQuery(id);
            PostEntity result = await _mediator.Send(query);
            if (result != null)
                return Ok(result);
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post(string context, int blogId)
        {
            var command = new CreatePostCommand(context, blogId);
            PostDto result = await _mediator.Send(command);
            if (result != null)
                return Ok(result);
            return NotFound();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

