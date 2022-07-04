using System;
namespace GameNews.Infrastructure.Entities
{
	public class LikesEntity
	{
		public int userId;

		public UserEntity user;

		public int postId;

		public PostEntity post;
	}
}

