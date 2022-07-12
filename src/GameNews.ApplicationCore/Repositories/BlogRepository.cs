using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.Context;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.ToDoItems.Repositories
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

        public BlogEntity CreateBlog(string name, string desc)
        {
            var blog = new BlogEntity();
            blog.Name = name;
            blog.Description = desc;
            _dbContext.Blogs.Add(blog);
            _dbContext.SaveChanges();
            return blog;
        }

        public BlogEntity EditBlog(int id, string name, string desc)
        {
            var tmp = _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefault();
            if (tmp != null)
            {
                tmp.Name = name;
                tmp.Description = desc;
                _dbContext.SaveChanges();
                return tmp;
            }
            return null;
        }

        public BlogEntity DeleteBlog(int id)
        {
            var tmp = _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefault();
            if (tmp != null)
            {
                _dbContext.Blogs.Remove(tmp);
                _dbContext.SaveChanges();
                return tmp;
            }
            return null;
        }
    }
}

