using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameNews.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    context = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    blogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_posts_blogs_blogId",
                        column: x => x.blogId,
                        principalTable: "blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ownerships",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false),
                    blogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ownerships", x => new { x.userId, x.blogId });
                    table.ForeignKey(
                        name: "FK_ownerships_blogs_blogId",
                        column: x => x.blogId,
                        principalTable: "blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ownerships_UserEntity_userId",
                        column: x => x.userId,
                        principalTable: "UserEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false),
                    blogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptions", x => new { x.userId, x.blogId });
                    table.ForeignKey(
                        name: "FK_subscriptions_blogs_blogId",
                        column: x => x.blogId,
                        principalTable: "blogs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subscriptions_UserEntity_userId",
                        column: x => x.userId,
                        principalTable: "UserEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "likes",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false),
                    postId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likes", x => new { x.userId, x.postId });
                    table.ForeignKey(
                        name: "FK_likes_posts_postId",
                        column: x => x.postId,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_likes_UserEntity_userId",
                        column: x => x.userId,
                        principalTable: "UserEntity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "postTags",
                columns: table => new
                {
                    postId = table.Column<int>(type: "int", nullable: false),
                    tagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postTags", x => new { x.postId, x.tagId });
                    table.ForeignKey(
                        name: "FK_postTags_posts_postId",
                        column: x => x.postId,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_postTags_tags_tagId",
                        column: x => x.tagId,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_likes_postId",
                table: "likes",
                column: "postId");

            migrationBuilder.CreateIndex(
                name: "IX_ownerships_blogId",
                table: "ownerships",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_posts_blogId",
                table: "posts",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_postTags_tagId",
                table: "postTags",
                column: "tagId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_blogId",
                table: "subscriptions",
                column: "blogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "likes");

            migrationBuilder.DropTable(
                name: "ownerships");

            migrationBuilder.DropTable(
                name: "postTags");

            migrationBuilder.DropTable(
                name: "subscriptions");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "blogs");
        }
    }
}
