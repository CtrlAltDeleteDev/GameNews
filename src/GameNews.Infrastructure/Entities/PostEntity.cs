using System;
namespace GameNews.Infrastructure.Entities
{
	public class PostEntity
	{
		public int Id { get; set; }

        public string Context { get; set; }

        public int BlogId { get; set; }

        public BlogEntity Blog { get; set; }

        public IEnumerable<PostTagEntity> PostTags { get; set; }

        public IEnumerable<LikesEntity> Likes { get; set; }
    }
}

