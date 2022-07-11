using MediatR;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.ToDoItems.Queries
{
	public class GetAllBlogsQuery : IRequest<List<BlogEntity>>
	{
	}
}

