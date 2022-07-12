using System;
using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.Context;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.ToDoItems.Repositories
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

		public PostEntity CreatePost(string context, int blogId)
        {
			var blog = _dbContext.Blogs.Where(x => x.Id == blogId).FirstOrDefault();
			if (blog != null)
            {
                var tmp = new PostEntity();
                tmp.Context = context;
                tmp.BlogId = blogId;
                _dbContext.Posts.Add(tmp);
                _dbContext.SaveChanges();
                return tmp;
            }
            return null;
        }
	}
}

