using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Commands;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class CreateBlogHandler : IRequestHandler<CreateBlogCommand, BlogEntity>
	{
        private readonly IBlogRepository _blogRepository;

        public CreateBlogHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public Task<BlogEntity> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var order = _blogRepository.CreateBlog(request.Title, request.Description);
            return Task.FromResult(order);
        }
    }
}

