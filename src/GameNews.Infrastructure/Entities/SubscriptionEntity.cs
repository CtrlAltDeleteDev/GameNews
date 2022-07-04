using System;
namespace GameNews.Infrastructure.Entities
{
	public class SubscriptionEntity
	{
		public int userId;

		public UserEntity user;

		public int blogId;

		public BlogEntity blog;
	}
}

