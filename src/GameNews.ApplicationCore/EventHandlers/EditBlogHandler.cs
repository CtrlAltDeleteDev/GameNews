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

        public async Task<BlogExtendedDto> Handle(EditBlogCommand request, CancellationToken cancellationToken)
        {
            BlogEntity check = await _blogRepository.GetBlogByIdAsync(request.Id, cancellationToken);
            if (check != null)
            {
                BlogEntity blog = _mapper.Convert(request);
                BlogEntity result = await _blogRepository.EditBlogAsync(blog, cancellationToken);
                BlogExtendedDto dto = _mapper.Convert(result);
                return dto;
            }
            throw new BlogNotFoundException();
        }
    }
}

