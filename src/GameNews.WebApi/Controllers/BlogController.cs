using Microsoft.AspNetCore.Mvc;
using GameNews.Infrastructure.Context;
using MediatR;
using GameNews.ApplicationCore.ToDoItems.Queries;
using GameNews.ApplicationCore.ToDoItems.Commands;
using GameNews.Infrastructure.Entities;

// dotnet ef database update --startup-project "src/GameNews.WebApi" --project "src/GameNews.Infrastructure"

//extension methods
//async await

namespace GameNews.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator; 

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllBlogsQuery();
            List<BlogEntity> result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetBlogByIdQuery(id);
            BlogEntity result = await _mediator.Send(query);
            if (result != null)
                return Ok(result);
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post(string name, string description)
        {
            var command = new CreateBlogCommand(name, description);
            BlogEntity result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, string name, string description)
        {
            if (name != null && description != null)
            {
                var command = new EditBlogCommand(id, name, description);
                BlogEntity result = await _mediator.Send(command);
                if (result != null)
                    return Ok(result);
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBlogCommand(id);
            BlogEntity result = await _mediator.Send(command);
            if (result != null)
                return Ok(result);
            return NotFound();
        }
    }
}

