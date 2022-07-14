using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Queries
{
	public class GetPostByIdQuery : IRequest<PostExtendedDto>
	{
		public int Id;

		public GetPostByIdQuery(int id)
		{
			Id = id;
		}
	}
}

