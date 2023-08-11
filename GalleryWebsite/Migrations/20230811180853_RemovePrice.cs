using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryWebsite.Migrations
{
    /// <inheritdoc />
    public partial class RemovePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Image");

            migrationBuilder.RenameColumn(
                name: "tags",
                table: "Image",
                newName: "Tags");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tags",
                table: "Image",
                newName: "tags");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Image",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
