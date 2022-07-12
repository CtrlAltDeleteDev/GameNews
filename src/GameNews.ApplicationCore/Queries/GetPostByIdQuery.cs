using System;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Queries
{
	public class GetPostByIdQuery : IRequest<PostEntity>
	{
		public int Id;

		public GetPostByIdQuery(int id)
		{
			Id = id;
		}
	}
}

