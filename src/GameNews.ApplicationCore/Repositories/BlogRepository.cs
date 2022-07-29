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

        public async Task<List<BlogEntity>> GetAllBlogsAsync(CancellationToken token)
        {
            var result = await _dbContext.Blogs.ToListAsync(token);
            return result;
        }

        public async Task<BlogEntity> GetBlogByIdAsync(int id, CancellationToken token)
        {
            var result = await _dbContext.Blogs.Where(x => x.Id == id).FirstOrDefaultAsync(token);
            return result;
        }

        public async Task<BlogEntity> CreateBlogAsync(BlogEntity blog, CancellationToken token)
        {
            await _dbContext.Blogs.AddAsync(blog, token);
            await _dbContext.SaveChangesAsync(token);
            return blog;
        }

        public async Task<BlogEntity> EditBlogAsync(BlogEntity blog, CancellationToken token)
        {
            var tmp = await GetBlogByIdAsync(blog.Id,token);
            tmp.Name = blog.Name;
            tmp.Description = blog.Description;
            await _dbContext.SaveChangesAsync(token);
            return tmp;
        }

        public async Task<BlogEntity> DeleteBlogAsync(BlogEntity blog, CancellationToken token)
        {
            _dbContext.Blogs.Remove(blog);
            await _dbContext.SaveChangesAsync(token);
            return blog;
        }
    }
}

