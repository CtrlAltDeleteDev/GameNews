using GameNews.ApplicationCore.Commands;
using GameNews.ApplicationCore.Exceptions;
using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class EditPostHandler : IRequestHandler<EditPostCommand, PostExtendedDto>
	{
        private readonly IPostRepository _postRepository;
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

		public EditPostHandler(IPostRepository postRepository, IMapper mapper, IBlogRepository blogRepository)
		{
            _postRepository = postRepository;
            _mapper = mapper;
            _blogRepository = blogRepository;
		}

        public async Task<PostExtendedDto> Handle(EditPostCommand request, CancellationToken cancellationToken)
        {
            if (await _postRepository.GetPostById(request.Id) != null)
            {
                if (await _blogRepository.GetBlogById(request.BlogId) != null)
                {
                    var post = await _mapper.Convert(request);
                    var result = await _postRepository.EditPost(post);
                    PostExtendedDto dto = await _mapper.Convert(result);
                    return dto;
                }
                throw new BlogNotFoundException();
            }
            throw new PostNotFoundException();
        }
    }
}

