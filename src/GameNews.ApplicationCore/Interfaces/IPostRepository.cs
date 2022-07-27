using System;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IPostRepository
	{
		public Task<List<PostEntity>> GetAllPostsAsync();

		public Task<PostEntity> GetPostByIdAsync(int id);

		public Task<PostEntity> CreatePostAsync(PostEntity post);

        public Task<PostEntity> EditPostAsync(PostEntity post);

        public Task<PostEntity> DeletePostAsync(PostEntity post);
    }
}

