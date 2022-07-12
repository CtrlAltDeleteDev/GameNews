using System;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Commands
{
	public class CreatePostCommand : IRequest<PostDto>
	{
		public string Context;

		public int BlogId;

        public CreatePostCommand(string context, int blogId)
		{
			Context = context;
			BlogId = blogId;
		}
	}
}

