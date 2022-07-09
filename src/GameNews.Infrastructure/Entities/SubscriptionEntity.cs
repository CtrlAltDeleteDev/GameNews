using System;
namespace GameNews.Infrastructure.Entities
{
	public class SubscriptionEntity
	{
		public int UserId { get; set; }

        public UserEntity User { get; set; }

        public int BlogId { get; set; }

        public BlogEntity Blog { get; set; }
    }
}

