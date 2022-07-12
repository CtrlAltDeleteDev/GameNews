﻿using System;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IPostRepository
	{
		public List<PostEntity> GetAllPosts();
		public PostEntity GetPostById(int id);
		public PostEntity CreatePost(string context, int blogId);
	}
}

