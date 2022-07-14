using System;
namespace GameNews.Infrastructure.DataTransferObjects
{
	public class PostExtendedDto : PostDto
	{
		public int Id { get; set; }

		public PostExtendedDto(int id, string context, int blogId) : base(context, blogId)
		{
			Id = id;
		}
	}
}

