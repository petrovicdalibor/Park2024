using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Park2024.Migrations
{
    /// <inheritdoc />
    public partial class changeusertablename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "INDO_183284_183269",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "INDO_183284_183269",
                newName: "Profil",
                newSchema: "INDO_183284_183269");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profil",
                schema: "INDO_183284_183269",
                table: "Profil",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profil",
                schema: "INDO_183284_183269",
                table: "Profil");

            migrationBuilder.RenameTable(
                name: "Profil",
                schema: "INDO_183284_183269",
                newName: "User",
                newSchema: "INDO_183284_183269");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "INDO_183284_183269",
                table: "User",
                column: "Id");
        }
    }
}
