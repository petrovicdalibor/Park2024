using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Park2024.Migrations
{
    /// <inheritdoc />
    public partial class daci : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "Identity",
                newName: "UserTokens",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "Identity",
                newName: "UserRoles",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "Identity",
                newName: "UserLogins",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "Identity",
                newName: "UserClaims",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Identity",
                newName: "User",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "Sopstvenici",
                schema: "Identity",
                newName: "Sopstvenici",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "Identity",
                newName: "RoleClaims",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Identity",
                newName: "Role",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "Korisnici",
                schema: "Identity",
                newName: "Korisnici",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "Identity",
                newName: "AspNetUsers",
                newSchema: "INDO_183284_183269");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                schema: "INDO_183284_183269",
                newName: "UserTokens",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                schema: "INDO_183284_183269",
                newName: "UserRoles",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                schema: "INDO_183284_183269",
                newName: "UserLogins",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                schema: "INDO_183284_183269",
                newName: "UserClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "INDO_183284_183269",
                newName: "User",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Sopstvenici",
                schema: "INDO_183284_183269",
                newName: "Sopstvenici",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                schema: "INDO_183284_183269",
                newName: "RoleClaims",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "INDO_183284_183269",
                newName: "Role",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "Korisnici",
                schema: "INDO_183284_183269",
                newName: "Korisnici",
                newSchema: "Identity");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                schema: "INDO_183284_183269",
                newName: "AspNetUsers",
                newSchema: "Identity");
        }
    }
}
