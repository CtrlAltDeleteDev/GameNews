using GameNews.ApplicationCore.Commands;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IMapper
	{
		public Task<PostExtendedDto> Convert(PostEntity post);

		public Task<List<PostExtendedDto>> Convert(List<PostEntity> posts);

		public Task<PostEntity> Convert(CreatePostCommand command);

        public Task<PostEntity> Convert(EditPostCommand command);


        public Task<BlogExtendedDto> Convert(BlogEntity blog);

        public Task<List<BlogExtendedDto>> Convert(List<BlogEntity> posts);

		public Task<BlogEntity> Convert(CreateBlogCommand command);

        public Task<BlogEntity> Convert(EditBlogCommand command);
    }
}

