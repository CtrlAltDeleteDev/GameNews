using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Commands;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class DeleteBlogHandler : IRequestHandler<DeleteBlogCommand, BlogEntity>
	{
        private readonly IBlogRepository _blogRepository;

		public DeleteBlogHandler(IBlogRepository blogRepository)
		{
            _blogRepository = blogRepository;
		}

        public Task<BlogEntity> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            var result = _blogRepository.DeleteBlog(request.Id);
            return Task.FromResult(result);
        }
    }
}

