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

		public async Task<List<PostEntity>> GetAllPostsAsync(CancellationToken token)
        {
			var result = await _dbContext.Posts.ToListAsync(token);
			return result;
        }

		public async Task<PostEntity> GetPostByIdAsync(int id, CancellationToken token)
        {
			var result = await _dbContext.Posts.Where(x => x.Id == id).FirstOrDefaultAsync(token);
			return result;
        }

		public async Task<PostEntity> CreatePostAsync(PostEntity post, CancellationToken token)
		{
			await _dbContext.Posts.AddAsync(post, token);
			await _dbContext.SaveChangesAsync(token);
			return post;
		}

        public async Task<PostEntity> EditPostAsync(PostEntity post, CancellationToken token)
        {
			var tmp = await GetPostByIdAsync(post.Id, token);
			tmp.Context = post.Context;
			tmp.BlogId = post.BlogId;
            await _dbContext.SaveChangesAsync(token);
			return tmp;
        }

		public async Task<PostEntity> DeletePostAsync(PostEntity post, CancellationToken token)
        {
			_dbContext.Posts.Remove(post);
			await _dbContext.SaveChangesAsync(token);
			return post;
        }
    }
}

