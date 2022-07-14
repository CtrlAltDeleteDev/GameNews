namespace GameNews.Infrastructure.Entities
{
	public class BlogEntity
	{
		public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public IEnumerable<PostEntity> Posts { get; set; }

        public IEnumerable<SubscriptionEntity> Subscriptions { get; set; }

        public IEnumerable<OwnershipEntity> Ownerships { get; set; }
    }
}

