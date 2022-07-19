using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IBlogRepository
	{
		public Task<List<BlogEntity>> GetAllBlogs();
		public Task<BlogEntity> GetBlogById(int id);
		public Task<BlogEntity> CreateBlog(BlogEntity blog);
        public Task<BlogEntity> EditBlog(BlogEntity blog);
		public Task<BlogEntity> DeleteBlog(BlogEntity blog);
    }
}

