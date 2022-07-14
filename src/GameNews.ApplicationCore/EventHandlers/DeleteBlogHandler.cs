﻿using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.Commands;
using MediatR;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;
using GameNews.ApplicationCore.Exceptions;

namespace GameNews.ApplicationCore.EventHandlers
{
	public class DeleteBlogHandler : IRequestHandler<DeleteBlogCommand, BlogExtendedDto>
	{
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public DeleteBlogHandler(IBlogRepository blogRepository, IMapper mapper)
		{
            _blogRepository = blogRepository;
            _mapper = mapper;
		}

        public Task<BlogExtendedDto> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            BlogEntity blog = _blogRepository.GetBlogById(request.Id);
            if (blog != null)
            {
                BlogEntity result = _blogRepository.DeleteBlog(blog);
                BlogExtendedDto dto = _mapper.Convert(result);
                return Task.FromResult(dto);
            }
            throw new BlogNotFoundException();
        }
    }
}

