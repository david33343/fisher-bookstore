using Microsoft.EntityFrameworkCore.Migrations;

namespace Fisher.Bookstore.Api.Migrations
{
    public partial class authorupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publicationDate",
                table: "Books",
                newName: "PublishDate");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "Publisher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Books",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "PublishDate",
                table: "Books",
                newName: "publicationDate");
        }
    }
}
