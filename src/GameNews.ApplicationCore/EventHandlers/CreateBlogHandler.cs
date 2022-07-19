using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Commands;
using GameNews.Infrastructure.Entities;
using MediatR;
using GameNews.Infrastructure.DataTransferObjects;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class CreateBlogHandler : IRequestHandler<CreateBlogCommand, BlogExtendedDto>
	{
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlogHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<BlogExtendedDto> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            BlogEntity blog = await _mapper.Convert(request);
            BlogEntity result = await _blogRepository.CreateBlog(blog);
            BlogExtendedDto dto = await _mapper.Convert(result);
            return dto;
        }
    }
}

