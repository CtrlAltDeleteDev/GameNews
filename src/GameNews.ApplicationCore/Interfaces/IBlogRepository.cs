using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IBlogRepository
	{
		public Task<List<BlogEntity>> GetAllBlogsAsync();

		public Task<BlogEntity> GetBlogByIdAsync(int id);

		public Task<BlogEntity> CreateBlogAsync(BlogEntity blog);

        public Task<BlogEntity> EditBlogAsync(BlogEntity blog);

		public Task<BlogEntity> DeleteBlogAsync(BlogEntity blog);
    }
}

