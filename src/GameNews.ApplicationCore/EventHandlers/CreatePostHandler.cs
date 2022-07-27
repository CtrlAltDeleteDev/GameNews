using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Commands;
using GameNews.Infrastructure.DataTransferObjects;
using MediatR;
using GameNews.ApplicationCore.Exceptions;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class CreatePostHandler : IRequestHandler<CreatePostCommand,PostExtendedDto>
	{
        private readonly IPostRepository _postRepository;
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

		public CreatePostHandler(IPostRepository postRepository, IMapper mapper, IBlogRepository blogRepository)
		{
            _postRepository = postRepository;
            _blogRepository = blogRepository;
            _mapper = mapper;
		}

        public async Task<PostExtendedDto> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            if (await _blogRepository.GetBlogByIdAsync(request.BlogId) != null)
            {
                PostEntity post = _mapper.Convert(request);
                PostEntity result = await _postRepository.CreatePostAsync(post);
                PostExtendedDto dto = _mapper.Convert(result);
                return dto;
            }
            throw new BlogNotFoundException();
        }
    }
}

