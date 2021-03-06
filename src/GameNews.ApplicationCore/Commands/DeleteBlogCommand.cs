using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Commands
{
	public class DeleteBlogCommand : IRequest<BlogExtendedDto>
	{
		public int Id;

		public DeleteBlogCommand(int id)
		{
			Id = id;
		}
	}
}

