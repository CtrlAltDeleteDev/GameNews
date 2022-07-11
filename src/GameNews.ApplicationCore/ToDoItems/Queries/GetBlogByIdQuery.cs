using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Queries
{
	public class GetBlogByIdQuery : IRequest<BlogEntity>
	{
		public int Id;

		public GetBlogByIdQuery(int id)
		{
			Id = id;
		}
	}
}

