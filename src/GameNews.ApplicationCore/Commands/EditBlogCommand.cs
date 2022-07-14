using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Commands
{
	public class EditBlogCommand : IRequest<BlogExtendedDto>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public EditBlogCommand(int id, BlogDto dto)
        {
            Id = id;
            Title = dto.Title;
            Description = dto.Desc;
        }
    }
}

