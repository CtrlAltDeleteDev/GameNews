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

        public List<BlogEntity> GetAllBlogs()
        {
            var result = _dbContext.Blogs.ToList();
            return result;
        }

        public BlogEntity GetBlogById(int id)
        {
            var result = _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public BlogEntity CreateBlog(BlogEntity blog)
        {
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
            return blog;
        }

        public BlogEntity EditBlog(BlogEntity blog)
        {
            var tmp = _dbContext.Blogs.Where(x => x.Id == blog.Id).FirstOrDefault();
            tmp.Name = blog.Name;
            tmp.Description = blog.Description;
            _dbContext.SaveChanges();
            return tmp;
        }

        public BlogEntity DeleteBlog(BlogEntity blog)
        {
            _dbContext.Blogs.Remove(blog);
            _dbContext.SaveChanges();
            return blog;
        }
    }
}

