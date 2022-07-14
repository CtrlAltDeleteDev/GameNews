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

        Task<BlogExtendedDto> IRequestHandler<CreateBlogCommand, BlogExtendedDto>.Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            BlogEntity blog = _mapper.Convert(request);
            BlogEntity result = _blogRepository.CreateBlog(blog);
            BlogExtendedDto dto = _mapper.Convert(result);
            return Task.FromResult(dto);
        }
    }
}

