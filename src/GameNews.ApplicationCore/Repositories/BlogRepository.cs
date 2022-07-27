using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.Context;
using GameNews.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameNews.ApplicationCore.Repositories
{
	public class BlogRepository : IBlogRepository
	{
        private readonly AppDbContext _dbContext;

        public BlogRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BlogEntity>> GetAllBlogsAsync()
        {
            var result = await _dbContext.Blogs.ToListAsync();
            return result;
        }

        public async Task<BlogEntity> GetBlogByIdAsync(int id)
        {
            var result = await _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<BlogEntity> CreateBlogAsync(BlogEntity blog)
        {
            await _dbContext.Blogs.AddAsync(blog);
            await _dbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<BlogEntity> EditBlogAsync(BlogEntity blog)
        {
            var tmp = await GetBlogByIdAsync(blog.Id);
            tmp.Name = blog.Name;
            tmp.Description = blog.Description;
            await _dbContext.SaveChangesAsync();
            return tmp;
        }

        public async Task<BlogEntity> DeleteBlogAsync(BlogEntity blog)
        {
            _dbContext.Blogs.Remove(blog);
            await _dbContext.SaveChangesAsync();
            return blog;
        }
    }
}

