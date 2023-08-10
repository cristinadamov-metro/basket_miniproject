using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Basket.Migrations
{
    /// <inheritdoc />
    public partial class ArticleLineRobert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ArticleLines_ArticleId",
                table: "ArticleLines",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLines_Articles_ArticleId",
                table: "ArticleLines",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLines_Articles_ArticleId",
                table: "ArticleLines");

            migrationBuilder.DropIndex(
                name: "IX_ArticleLines_ArticleId",
                table: "ArticleLines");
        }
    }
}
