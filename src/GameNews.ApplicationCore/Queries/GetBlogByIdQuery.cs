using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Queries
{
	public class GetBlogByIdQuery : IRequest<BlogExtendedDto>
	{
		public int Id;

		public GetBlogByIdQuery(int id)
		{
			Id = id;
		}
	}
}

