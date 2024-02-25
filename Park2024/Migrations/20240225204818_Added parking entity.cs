using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Park2024.Migrations
{
    /// <inheritdoc />
    public partial class Addedparkingentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parking",
                schema: "INDO_183284_183269",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Sopstvenik_Id = table.Column<int>(type: "integer", nullable: false),
                    Ulica = table.Column<string>(type: "text", nullable: false),
                    Cena = table.Column<int>(type: "integer", nullable: false),
                    Br_Mesta = table.Column<int>(type: "integer", nullable: false),
                    Zona_Id = table.Column<int>(type: "integer", nullable: false),
                    Grad_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parking_sopstvenik_Sopstvenik_Id",
                        column: x => x.Sopstvenik_Id,
                        principalSchema: "INDO_183284_183269",
                        principalTable: "sopstvenik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parking_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "Parking",
                column: "Sopstvenik_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parking",
                schema: "INDO_183284_183269");
        }
    }
}
