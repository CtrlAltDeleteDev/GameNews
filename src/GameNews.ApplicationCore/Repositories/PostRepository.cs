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

		public List<PostEntity> GetAllPosts()
        {
			var result = _dbContext.Posts.ToList();
			return result;
        }

		public PostEntity GetPostById(int id)
        {
			var result = _dbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
			return result;
        }

		public PostEntity CreatePost(PostEntity post)
		{
			_dbContext.Posts.Add(post);
			_dbContext.SaveChanges();
			return post;
		}

        public PostEntity EditPost(PostEntity post)
        {
			var tmp = GetPostById(post.Id);
			tmp.Context = post.Context;
			tmp.BlogId = post.BlogId;
            _dbContext.SaveChanges();
			return tmp;
        }

		public PostEntity DeletePost(PostEntity post)
        {
			_dbContext.Posts.Remove(post);
			_dbContext.SaveChanges();
			return post;
        }
    }
}

