using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.Commands
{
	public class CreateBlogCommand :IRequest<BlogExtendedDto>
	{
        public string Title { get; set; }

		public string Description { get; set; }

        public CreateBlogCommand(BlogDto dto)
        {
            Title = dto.Title;
            Description = dto.Desc;
        }
    }
}

