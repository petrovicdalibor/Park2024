using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Park2024.Migrations
{
    /// <inheritdoc />
    public partial class changeusertablename1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profil",
                schema: "INDO_183284_183269",
                table: "Profil");

            migrationBuilder.RenameTable(
                name: "Profil",
                schema: "INDO_183284_183269",
                newName: "profil",
                newSchema: "INDO_183284_183269");

            migrationBuilder.AddPrimaryKey(
                name: "PK_profil",
                schema: "INDO_183284_183269",
                table: "profil",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_profil",
                schema: "INDO_183284_183269",
                table: "profil");

            migrationBuilder.RenameTable(
                name: "profil",
                schema: "INDO_183284_183269",
                newName: "Profil",
                newSchema: "INDO_183284_183269");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profil",
                schema: "INDO_183284_183269",
                table: "Profil",
                column: "Id");
        }
    }
}
