using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IBlogRepository
	{
		public List<BlogEntity> GetAllBlogs();
		public BlogEntity GetBlogById(int id);
		public BlogEntity CreateBlog(string name, string desc);
        public BlogEntity EditBlog(int id, string name, string desc);
		public BlogEntity DeleteBlog(int id);
    }
}

