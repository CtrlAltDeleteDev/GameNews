using System;
namespace GameNews.Infrastructure.Entities
{
	public class PostTagEntity
	{
		public int postId { get; set; }

        public PostEntity post { get; set; }

        public int tagId { get; set; }

        public TagEntity tag { get; set; }
    }
}

