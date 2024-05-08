using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBackTask2.Migrations
{
    /// <inheritdoc />
    public partial class OrganicProductNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__organicProducts",
                table: "_organicProducts");

            migrationBuilder.RenameTable(
                name: "_organicProducts",
                newName: "OrganicProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganicProducts",
                table: "OrganicProducts",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganicProducts",
                table: "OrganicProducts");

            migrationBuilder.RenameTable(
                name: "OrganicProducts",
                newName: "_organicProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK__organicProducts",
                table: "_organicProducts",
                column: "Id");
        }
    }
}
