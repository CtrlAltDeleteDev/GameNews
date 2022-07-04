using System;
namespace GameNews.Infrastructure.Entities
{
	public class PostEntity
	{
		public int id { get; set; }

        public string context { get; set; }

        public int blogId { get; set; }

        public BlogEntity blog { get; set; }

        public IEnumerable<PostTagEntity> postTags { get; set; }

        public IEnumerable<LikesEntity> likes { get; set; }
    }
}

