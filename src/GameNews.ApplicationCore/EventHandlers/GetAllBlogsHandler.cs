using GameNews.ApplicationCore.Interfaces;
using GameNews.ApplicationCore.ToDoItems.Queries;
using GameNews.Infrastructure.Entities;
using MediatR;

namespace GameNews.ApplicationCore.ToDoItems.EventHandlers
{
	public class GetAllBlogsHandler : IRequestHandler<GetAllBlogsQuery, List<BlogEntity>>
	{
        private readonly IBlogRepository _blogRepository;

        public GetAllBlogsHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
	
        public Task<List<BlogEntity>> Handle(GetAllBlogsQuery request, CancellationToken cancellationToken)
        {
            var blogs = _blogRepository.GetAllBlogs();
            return Task.FromResult(blogs);
        }
    }
}

