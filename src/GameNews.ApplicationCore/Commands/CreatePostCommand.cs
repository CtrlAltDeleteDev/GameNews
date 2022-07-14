using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Commands
{
	public class CreatePostCommand : IRequest<PostExtendedDto>
	{
		public string Context;

		public int BlogId;

        public CreatePostCommand(PostDto dto)
		{
			Context = dto.Context;
			BlogId = dto.BlogId;
		}
	}
}

