using System;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IPostRepository
	{
		public Task<List<PostEntity>> GetAllPosts();
		public Task<PostEntity> GetPostById(int id);
		public Task<PostEntity> CreatePost(PostEntity post);
        public Task<PostEntity> EditPost(PostEntity post);
        public Task<PostEntity> DeletePost(PostEntity post);
    }
}

