using System;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IPostRepository
	{
		public Task<List<PostEntity>> GetAllPostsAsync(CancellationToken token);

		public Task<PostEntity> GetPostByIdAsync(int id, CancellationToken token);

		public Task<PostEntity> CreatePostAsync(PostEntity post, CancellationToken token);

        public Task<PostEntity> EditPostAsync(PostEntity post, CancellationToken token);

        public Task<PostEntity> DeletePostAsync(PostEntity post, CancellationToken token);
    }
}

