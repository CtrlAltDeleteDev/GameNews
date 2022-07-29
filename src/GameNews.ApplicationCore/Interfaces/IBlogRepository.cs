using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IBlogRepository
	{
		public Task<List<BlogEntity>> GetAllBlogsAsync(CancellationToken token);

		public Task<BlogEntity> GetBlogByIdAsync(int id, CancellationToken token);

		public Task<BlogEntity> CreateBlogAsync(BlogEntity blog, CancellationToken token);

        public Task<BlogEntity> EditBlogAsync(BlogEntity blog, CancellationToken token);

		public Task<BlogEntity> DeleteBlogAsync(BlogEntity blog, CancellationToken token);
    }
}

