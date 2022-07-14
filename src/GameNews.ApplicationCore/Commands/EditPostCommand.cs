using System;
using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Commands
{
	public class EditPostCommand : IRequest<PostExtendedDto>
	{
		public int Id { get; set; }

		public string Context { get; set; }

		public int BlogId { get; set; }

        public EditPostCommand(PostExtendedDto dto)
        {
			Id = dto.Id;
            Context = dto.Context;
			BlogId = dto.BlogId;
        }

	}
}

