using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Queries;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class GetAllPostsHandler : IRequestHandler<GetAllPostsQuery,List<PostEntity>>
	{
        private readonly IPostRepository _postRepository;

		public GetAllPostsHandler(IPostRepository postRepository)
		{
            _postRepository = postRepository;
		}

        public Task<List<PostEntity>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            var result = _postRepository.GetAllPosts();
            return Task.FromResult(result);
        }
    }
}

