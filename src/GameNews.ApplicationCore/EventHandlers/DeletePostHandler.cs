using GameNews.ApplicationCore.Commands;
using GameNews.ApplicationCore.Exceptions;
using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class DeletePostHandler : IRequestHandler<DeletePostCommand,PostExtendedDto>
	{
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

		public DeletePostHandler(IPostRepository postRepository, IMapper mapper)
		{
            _postRepository = postRepository;
            _mapper = mapper;
		}

        public Task<PostExtendedDto> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
           PostEntity post = _postRepository.GetPostById(request.Id);
           if (post != null)
           {
                PostEntity deletion = _postRepository.DeletePost(post);
                PostExtendedDto result = _mapper.Convert(deletion);
                return Task.FromResult(result);
           }
            throw new PostNotFoundException();
        }
    }
}

