using GameNews.Infrastructure.DataTransferObjects;
using MediatR;

namespace GameNews.ApplicationCore.Queries
{
	public class GetAllPostsQuery : IRequest<List<PostExtendedDto>>
	{

	}
}

