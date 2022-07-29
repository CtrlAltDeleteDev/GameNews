using GameNews.ApplicationCore.Exceptions;
using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Queries;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class GetAllBlogsHandler : IRequestHandler<GetAllBlogsQuery, List<BlogExtendedDto>>
	{
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetAllBlogsHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
	
        public async Task<List<BlogExtendedDto>> Handle(GetAllBlogsQuery request, CancellationToken cancellationToken)
        {
            List<BlogEntity> blogs = await _blogRepository.GetAllBlogsAsync(cancellationToken);
            if (blogs.FirstOrDefault() != null)
            {
                List<BlogExtendedDto> result = _mapper.Convert(blogs);
                return result;
            }
            throw new BlogNotFoundException();
        }
    }
}

