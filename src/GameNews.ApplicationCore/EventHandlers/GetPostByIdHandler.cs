using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Queries;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery,PostEntity>
	{
        private readonly IPostRepository _postRepository;

		public GetPostByIdHandler(IPostRepository postRepository)
		{
            _postRepository = postRepository;
		}

        public Task<PostEntity> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            var result = _postRepository.GetPostById(request.Id);
            return Task.FromResult(result);
        }
    }
}

