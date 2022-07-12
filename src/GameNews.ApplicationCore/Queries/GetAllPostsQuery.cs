using System;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Queries
{
	public class GetAllPostsQuery : IRequest<List<PostEntity>>
	{

	}
}

