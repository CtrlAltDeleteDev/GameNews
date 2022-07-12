using System;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Commands
{
	public class CreateBlogCommand :IRequest<BlogEntity>
	{
        public CreateBlogCommand(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }

		public string Description { get; set; }
	}
}

