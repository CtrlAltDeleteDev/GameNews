using System;
namespace GameNews.Infrastructure.DataTransferObjects
{
	public class BlogDto
	{
		public string Title { get; set; }
		public string? Desc { get; set; }

		public BlogDto(string title, string desc)
		{
			Title = title;
			Desc = desc;
		}
	}
}

