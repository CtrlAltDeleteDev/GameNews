using System;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.Commands
{
	public class EditBlogCommand : IRequest<BlogEntity>
    {
        public EditBlogCommand(int id, string title, string desc)
        {
            Id = id;
            Title = title;
            Description = desc;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}

