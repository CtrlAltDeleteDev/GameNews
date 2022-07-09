using System;
namespace GameNews.Infrastructure.Entities
{
	public class UserEntity
	{
		public int Id { get; set; }

        public IEnumerable<SubscriptionEntity> Subscriptions { get; set; }

        public IEnumerable<OwnershipEntity> Ownerships { get; set; }

        public IEnumerable<LikesEntity> Likes { get; set; }
    }
}

