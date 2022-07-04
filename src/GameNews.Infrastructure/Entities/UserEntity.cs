using System;
namespace GameNews.Infrastructure.Entities
{
	public class UserEntity
	{
		public int id { get; set; }

        public IEnumerable<SubscriptionEntity> subscriptions { get; set; }

        public IEnumerable<OwnershipEntity> ownerships { get; set; }

        public IEnumerable<LikesEntity> likes { get; set; }
    }
}

