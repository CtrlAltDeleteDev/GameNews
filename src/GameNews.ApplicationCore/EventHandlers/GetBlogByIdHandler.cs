using GameNews.ApplicationCore.Exceptions;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Queries;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class GetBlogByIdHandler : IRequestHandler<GetBlogByIdQuery, BlogExtendedDto>
	{
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogByIdHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        Task<BlogExtendedDto> IRequestHandler<GetBlogByIdQuery, BlogExtendedDto>.Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            BlogEntity blog = _blogRepository.GetBlogById(request.Id);
            if (blog != null)
            {
                BlogExtendedDto result = _mapper.Convert(blog);
                return Task.FromResult(result);
            }
            throw new BlogNotFoundException();
        }
    }
}

