using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.Context;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Repositories
{
	public class PostRepository : IPostRepository
	{
		private readonly AppDbContext _dbContext;

		public PostRepository(AppDbContext dbContext)
        {
			_dbContext = dbContext;
        }

		public async Task<List<PostEntity>> GetAllPosts()
        {
			var result = _dbContext.Posts.ToList();
			return result;
        }

		public async Task<PostEntity> GetPostById(int id)
        {
			var result = _dbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
			return result;
        }

		public async Task<PostEntity> CreatePost(PostEntity post)
		{
			_dbContext.Posts.Add(post);
			_dbContext.SaveChanges();
			return post;
		}

        public async Task<PostEntity> EditPost(PostEntity post)
        {
			var tmp = await GetPostById(post.Id);
			tmp.Context = post.Context;
			tmp.BlogId = post.BlogId;
            _dbContext.SaveChanges();
			return tmp;
        }

		public async Task<PostEntity> DeletePost(PostEntity post)
        {
			_dbContext.Posts.Remove(post);
			_dbContext.SaveChanges();
			return post;
        }
    }
}

