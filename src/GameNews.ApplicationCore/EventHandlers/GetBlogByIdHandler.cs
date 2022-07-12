using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Queries;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class GetBlogByIdHandler : IRequestHandler<GetBlogByIdQuery,BlogEntity>
	{
        private readonly IBlogRepository _blogRepository;

        public GetBlogByIdHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public Task<BlogEntity> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _blogRepository.GetBlogById(request.Id);
            return Task.FromResult(result);
        }
    }
}

