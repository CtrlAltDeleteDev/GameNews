using System;
namespace GameNews.Infrastructure.DataTransferObjects
{
	public class PostDto
	{
		public string Context { get; set; }
		public int BlogId { get; set; }

        public PostDto(string context, int blogId)
        {
            Context = context;
            BlogId = blogId;
        }
    }
}

