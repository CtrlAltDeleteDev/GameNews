using System;
namespace GameNews.Infrastructure.Entities
{
	public class TagEntity
	{
		public int id { get; set; }

		public string value { get; set; }

		public IEnumerable<PostTagEntity> postTags { get; set; }
    }
}

