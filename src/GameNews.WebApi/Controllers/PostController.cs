using GameNews.Infrastructure.DataTransferObjects;
using GameNews.ApplicationCore.Commands;
using GameNews.ApplicationCore.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using GameNews.ApplicationCore.Exceptions;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GameNews.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController (IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllPostsQuery();
            var result = new List<PostExtendedDto>();
            try
            {
                result = await _mediator.Send(query);
            }
            catch (PostNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetPostByIdQuery(id);
            PostExtendedDto result;

            try
            {
                result = await _mediator.Send(query);
            }
            catch(PostNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostDto post)
        {
            var command = new CreatePostCommand(post);
            PostExtendedDto result;

            try
            {
               result = await _mediator.Send(command);
            }
            catch (BlogNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] PostExtendedDto post)
        {
            var command = new EditPostCommand(post);
            PostExtendedDto result;

            try
            {
                result = await _mediator.Send(command);
            }
            catch (Exception ex)
            {
                if (ex is PostNotFoundException || ex is BlogNotFoundException)
                    return NotFound();
                throw;// why must it be here??????
            }
            
            return Ok(result);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeletePostCommand(id);
            PostExtendedDto result;

            try
            {
                result = await _mediator.Send(command);
            }
            catch(PostNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}

