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

        public Task<PostExtendedDto> Handle(EditPostCommand request, CancellationToken cancellationToken)
        {
            if (_postRepository.GetPostById(request.Id) != null)
            {
                if (_blogRepository.GetBlogById(request.BlogId) != null)
                {
                    var post = _mapper.Convert(request);
                    var result = _postRepository.EditPost(post);
                    PostExtendedDto dto = _mapper.Convert(result);
                    return Task.FromResult(dto);
                }
                throw new BlogNotFoundException();
            }
            throw new PostNotFoundException();
        }
    }
}

