using Microsoft.AspNetCore.Mvc;
using MediatR;
using GameNews.ApplicationCore.Queries;
using GameNews.ApplicationCore.Commands;
using GameNews.Infrastructure.Entities;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.ApplicationCore.Exceptions;

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
            List<Infrastructure.DataTransferObjects.BlogExtendedDto> result;

            try
            {
                result = await _mediator.Send(query);
            }
            catch (BlogNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetBlogByIdQuery(id);
            Infrastructure.DataTransferObjects.BlogExtendedDto result;

            try
            {
                result = await _mediator.Send(query);
            }
            catch(BlogNotFoundException)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BlogDto blog)
        {
            var command = new CreateBlogCommand(blog);
            Infrastructure.DataTransferObjects.BlogExtendedDto result = await _mediator.Send<Infrastructure.DataTransferObjects.BlogExtendedDto>(command);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] BlogDto blog)
        {
            var command = new EditBlogCommand(id, blog);
            Infrastructure.DataTransferObjects.BlogExtendedDto result;

            try
            {
                result = await _mediator.Send(command);
            }
            catch(BlogNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBlogCommand(id);
            Infrastructure.DataTransferObjects.BlogExtendedDto result;

            try
            {
                result = await _mediator.Send(command);
            }
            catch(BlogNotFoundException)
            {
                return NotFound();
            }

            return Ok(result);
        }

    }
}


