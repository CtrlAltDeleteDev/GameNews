using MediatR;
using GameNews.Infrastructure.DataTransferObjects;

namespace GameNews.ApplicationCore.Queries
{
	public class GetAllBlogsQuery : IRequest<List<BlogExtendedDto>>
	{
	}
}

