using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.Context;
using GameNews.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameNews.ApplicationCore.Repositories
{
	public class PostRepository : IPostRepository
	{
		private readonly AppDbContext _dbContext;

		public PostRepository(AppDbContext dbContext)
        {
			_dbContext = dbContext;
        }

		public async Task<List<PostEntity>> GetAllPostsAsync()
        {
			var result = await _dbContext.Posts.ToListAsync();
			return result;
        }

		public async Task<PostEntity> GetPostByIdAsync(int id)
        {
			var result = await _dbContext.Posts.Where(x => x.Id == id).FirstOrDefaultAsync();
			return result;
        }

		public async Task<PostEntity> CreatePostAsync(PostEntity post)
		{
			await _dbContext.Posts.AddAsync(post);
			await _dbContext.SaveChangesAsync();
			return post;
		}

        public async Task<PostEntity> EditPostAsync(PostEntity post)
        {
			var tmp = await GetPostByIdAsync(post.Id);
			tmp.Context = post.Context;
			tmp.BlogId = post.BlogId;
            await _dbContext.SaveChangesAsync();
			return tmp;
        }

		public async Task<PostEntity> DeletePostAsync(PostEntity post)
        {
			_dbContext.Posts.Remove(post);
			await _dbContext.SaveChangesAsync();
			return post;
        }
    }
}

