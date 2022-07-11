using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Commands;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class EditBlogHandler : IRequestHandler<EditBlogCommand, BlogEntity>
	{
        private readonly IBlogRepository _blogRepository;

		public EditBlogHandler(IBlogRepository blogRepository)
		{
            _blogRepository = blogRepository;
		}

        public Task<BlogEntity> Handle(EditBlogCommand request, CancellationToken cancellationToken)
        {
            var result = _blogRepository.EditBlog(request.Id, request.Title, request.Description);
            return Task.FromResult(result);
        }
    }
}

