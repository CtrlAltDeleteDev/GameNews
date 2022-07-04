using System;
namespace GameNews.Infrastructure.Entities
{
	public class BlogEntity
	{
		public int id { get; set; }

        public string name { get; set; }

        public string? description { get; set; }

        public IEnumerable<PostEntity> posts { get; set; }

        public IEnumerable<SubscriptionEntity> subscriptions { get; set; }

        public IEnumerable<OwnershipEntity> ownerships { get; set; }
    }
}

