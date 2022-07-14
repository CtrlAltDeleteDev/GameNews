using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Commands;
using GameNews.Infrastructure.Entities;
using MediatR;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.ApplicationCore.Exceptions;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class EditBlogHandler : IRequestHandler<EditBlogCommand, BlogExtendedDto>
	{
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public EditBlogHandler(IBlogRepository blogRepository, IMapper mapper)
		{
            _blogRepository = blogRepository;
            _mapper = mapper;
		}

        Task<BlogExtendedDto> IRequestHandler<EditBlogCommand, BlogExtendedDto>.Handle(EditBlogCommand request, CancellationToken cancellationToken)
        {
            BlogEntity check = _blogRepository.GetBlogById(request.Id);
            if (check != null)
            {
                BlogEntity blog = _mapper.Convert(request);
                BlogEntity result = _blogRepository.EditBlog(blog);
                BlogExtendedDto dto = _mapper.Convert(result);
                return Task.FromResult(dto);
            }
            throw new BlogNotFoundException();
        }
    }
}

