using GameNews.ApplicationCore.Exceptions;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Queries;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class GetAllPostsHandler : IRequestHandler<GetAllPostsQuery,List<PostExtendedDto>>
	{
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

		public GetAllPostsHandler(IPostRepository postRepository, IMapper mapper)
		{
            _postRepository = postRepository;
            _mapper = mapper;
		}

        public async Task<List<PostExtendedDto>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            List<PostEntity> posts = await _postRepository.GetAllPostsAsync();
            if (posts.FirstOrDefault() != null)
            {
                List<PostExtendedDto> result = _mapper.Convert(posts);
                return result;
            }
            throw new PostNotFoundException();
        }
    }
}

