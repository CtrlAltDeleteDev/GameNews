using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Commands
{
	public class DeletePostCommand : IRequest<PostExtendedDto>
	{
		public int Id { get; set; }

		public DeletePostCommand(int id)
		{
			Id = id;
		}
	}
}

