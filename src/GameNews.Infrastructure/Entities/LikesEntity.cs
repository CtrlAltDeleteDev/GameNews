using System;
namespace GameNews.Infrastructure.Entities
{
	public class LikesEntity
	{
		public int UserId { get; set; }

		public UserEntity User { get; set; }

        public int PostId { get; set; }

        public PostEntity Post { get; set; }
    }
}

