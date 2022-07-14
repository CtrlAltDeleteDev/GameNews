using System;
namespace GameNews.Infrastructure.DataTransferObjects
{
	public class BlogExtendedDto :BlogDto
	{
		public int Id { get; set; }

		public BlogExtendedDto(int id, string title, string desc) : base(title,desc)
		{
			Id = id;
		}
	}
}

