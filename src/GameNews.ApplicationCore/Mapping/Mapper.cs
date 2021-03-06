using GameNews.ApplicationCore.Commands;
using GameNews.ApplicationCore.Interfaces;
using GameNews.Infrastructure.DataTransferObjects;
using GameNews.Infrastructure.Entities;

namespace GameNews.ApplicationCore.Mapping
{
	public class Mapper : IMapper
	{
        public PostExtendedDto Convert(PostEntity post)
        {
            var result = new PostExtendedDto(post.Id, post.Context, post.BlogId);
            return result;
        }

        public List<PostExtendedDto> Convert(List<PostEntity> posts)
        {
            var list = new List<PostExtendedDto>();
            foreach (var obj in posts)
                list.Add(new PostExtendedDto(obj.Id, obj.Context, obj.BlogId));
            return list;
        }

        public List<BlogExtendedDto> Convert(List<BlogEntity> posts)
        {
            var list = new List<BlogExtendedDto>();
            foreach (var obj in posts)
                list.Add(new BlogExtendedDto(obj.Id, obj.Name, obj.Description));
            return list;
        }

        public PostEntity Convert(CreatePostCommand command)
        {
            var dto = new PostEntity();
            dto.Context = command.Context;
            dto.BlogId = command.BlogId;
            return dto;
        }

        public PostEntity Convert(EditPostCommand command)
        {
            var dto = new PostEntity();
            dto.Id = command.Id;
            dto.Context = command.Context;
            dto.BlogId = command.BlogId;
            return dto;
        }

        public BlogExtendedDto Convert(BlogEntity blog)
        {
            var dto = new BlogExtendedDto(blog.Id, blog.Name, blog.Description);
            return dto;
        }

        public BlogEntity Convert(CreateBlogCommand command)
        {
            var dto = new BlogEntity();
            dto.Name = command.Title;
            dto.Description = command.Description;
            return dto;
        }

        public BlogEntity Convert(EditBlogCommand command)
        {
            var dto = new BlogEntity();
            dto.Id = command.Id;
            dto.Name = command.Title;
            dto.Description = command.Description;
            return dto;
        }
    }
}

