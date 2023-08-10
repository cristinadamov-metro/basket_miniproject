using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Basket.Migrations
{
    /// <inheritdoc />
    public partial class ArticleLineCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Baskets_BasketId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_BasketId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Articles");

            migrationBuilder.CreateTable(
                name: "ArticleLine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ArticleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    BasketId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArticleLine_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleLine_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleLine_ArticleId",
                table: "ArticleLine",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleLine_BasketId",
                table: "ArticleLine",
                column: "BasketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleLine");

            migrationBuilder.AddColumn<Guid>(
                name: "BasketId",
                table: "Articles",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_BasketId",
                table: "Articles",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Baskets_BasketId",
                table: "Articles",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id");
        }
    }
}
