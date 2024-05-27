using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eBookShop.Migrations
{
    public partial class eBookShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Publisher",
                newName: "PublisherName");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Genre",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Authors",
                newName: "AuthorName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Publisher",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Genre",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Authors",
                newName: "Title");
        }
    }
}
