using System;
namespace GameNews.Infrastructure.Entities
{
	public class TagEntity
	{
		public int Id { get; set; }

		public string Value { get; set; }

		public IEnumerable<PostTagEntity> PostTags { get; set; }
    }
}

