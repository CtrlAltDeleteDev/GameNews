using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IBlogRepository
	{
		public List<BlogEntity> GetAllBlogs();
		public BlogEntity GetBlogById(int id);
		public BlogEntity CreateBlog(BlogEntity blog);
        public BlogEntity EditBlog(BlogEntity blog);
		public BlogEntity DeleteBlog(BlogEntity blog);
    }
}

