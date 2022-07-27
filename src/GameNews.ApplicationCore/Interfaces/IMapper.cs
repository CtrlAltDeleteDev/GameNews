using GameNews.ApplicationCore.Commands;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Interfaces
{
	public interface IMapper
	{
		public PostExtendedDto Convert(PostEntity post);

		public List<PostExtendedDto> Convert(List<PostEntity> posts);

		public PostEntity Convert(CreatePostCommand command);

        public PostEntity Convert(EditPostCommand command);


        public BlogExtendedDto Convert(BlogEntity blog);

        public List<BlogExtendedDto> Convert(List<BlogEntity> posts);

		public BlogEntity Convert(CreateBlogCommand command);

        public BlogEntity Convert(EditBlogCommand command);
    }
}

