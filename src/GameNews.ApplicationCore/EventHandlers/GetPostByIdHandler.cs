using GameNews.ApplicationCore.Exceptions;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Queries;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery,PostExtendedDto>
	{
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostByIdHandler(IPostRepository postRepository, IMapper mapper)
		{
            _postRepository = postRepository;
            _mapper = mapper;
		}

        public async Task<PostExtendedDto> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            PostEntity post = await _postRepository.GetPostById(request.Id);
            if (post != null)
            {
                PostExtendedDto result = await _mapper.Convert(post);
                return result;
            }
            throw new PostNotFoundException();
        }
    }
}

