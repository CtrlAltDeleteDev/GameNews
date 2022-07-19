using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.Context;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Repositories
{
	public class BlogRepository : IBlogRepository
	{
        private readonly AppDbContext _dbContext;

        public BlogRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BlogEntity>> GetAllBlogs()
        {
            var result = _dbContext.Blogs.ToList();
            return result;
        }

        public async Task<BlogEntity> GetBlogById(int id)
        {
            var result = _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public async Task<BlogEntity> CreateBlog(BlogEntity blog)
        {
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
            return blog;
        }

        public async Task<BlogEntity> EditBlog(BlogEntity blog)
        {
            var tmp = await GetBlogById(blog.Id);
            tmp.Name = blog.Name;
            tmp.Description = blog.Description;
            _dbContext.SaveChanges();
            return tmp;
        }

        public async Task<BlogEntity> DeleteBlog(BlogEntity blog)
        {
            _dbContext.Blogs.Remove(blog);
            _dbContext.SaveChanges();
            return blog;
        }
    }
}

