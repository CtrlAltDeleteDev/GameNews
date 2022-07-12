using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Commands;
using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class CreatePostHandler : IRequestHandler<CreatePostCommand,PostDto>
	{
        private readonly IPostRepository _postRepository;

		public CreatePostHandler(IPostRepository postRepository)
		{
            _postRepository = postRepository;
		}

        public Task<PostDto> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var result = _postRepository.CreatePost(request.Context, request.BlogId);
            var dto = new PostDto(result.Context, result.BlogId);
            return Task.FromResult(dto);
        }
    }
}

