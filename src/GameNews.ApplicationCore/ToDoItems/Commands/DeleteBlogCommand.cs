using System;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Commands
{
	public class DeleteBlogCommand : IRequest<BlogEntity>
	{
		public int Id;

		public DeleteBlogCommand(int id)
		{
			Id = id;
		}
	}
}

