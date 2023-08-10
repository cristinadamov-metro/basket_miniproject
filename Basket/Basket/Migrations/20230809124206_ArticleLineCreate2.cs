using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Basket.Migrations
{
    /// <inheritdoc />
    public partial class ArticleLineCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLine_Articles_ArticleId",
                table: "ArticleLine");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLine_Baskets_BasketId",
                table: "ArticleLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleLine",
                table: "ArticleLine");

            migrationBuilder.RenameTable(
                name: "ArticleLine",
                newName: "ArticleLines");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleLine_BasketId",
                table: "ArticleLines",
                newName: "IX_ArticleLines_BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleLine_ArticleId",
                table: "ArticleLines",
                newName: "IX_ArticleLines_ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleLines",
                table: "ArticleLines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLines_Articles_ArticleId",
                table: "ArticleLines",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLines_Baskets_BasketId",
                table: "ArticleLines",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLines_Articles_ArticleId",
                table: "ArticleLines");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLines_Baskets_BasketId",
                table: "ArticleLines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleLines",
                table: "ArticleLines");

            migrationBuilder.RenameTable(
                name: "ArticleLines",
                newName: "ArticleLine");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleLines_BasketId",
                table: "ArticleLine",
                newName: "IX_ArticleLine_BasketId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleLines_ArticleId",
                table: "ArticleLine",
                newName: "IX_ArticleLine_ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleLine",
                table: "ArticleLine",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLine_Articles_ArticleId",
                table: "ArticleLine",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLine_Baskets_BasketId",
                table: "ArticleLine",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");
        }
    }
}
