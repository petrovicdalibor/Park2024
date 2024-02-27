using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Park2024.Migrations
{
    /// <inheritdoc />
    public partial class Addedentitites1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parking_sopstvenik_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "Parking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parking",
                schema: "INDO_183284_183269",
                table: "Parking");

            migrationBuilder.RenameTable(
                name: "Parking",
                schema: "INDO_183284_183269",
                newName: "parking",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameIndex(
                name: "IX_Parking_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                newName: "IX_parking_Sopstvenik_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_parking",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "grad",
                schema: "INDO_183284_183269",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ime = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grad", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "zalbi",
                schema: "INDO_183284_183269",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tip = table.Column<string>(type: "text", nullable: false),
                    opis = table.Column<string>(type: "text", nullable: false),
                    parking_id = table.Column<int>(type: "integer", nullable: false),
                    korisnik_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zalbi", x => x.id);
                    table.ForeignKey(
                        name: "FK_zalbi_korisnik_korisnik_id",
                        column: x => x.korisnik_id,
                        principalSchema: "INDO_183284_183269",
                        principalTable: "korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zalbi_parking_parking_id",
                        column: x => x.parking_id,
                        principalSchema: "INDO_183284_183269",
                        principalTable: "parking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "zona",
                schema: "INDO_183284_183269",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ime = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zona", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_parking_Grad_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Grad_Id");

            migrationBuilder.CreateIndex(
                name: "IX_parking_Zona_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Zona_Id");

            migrationBuilder.CreateIndex(
                name: "IX_zalbi_korisnik_id",
                schema: "INDO_183284_183269",
                table: "zalbi",
                column: "korisnik_id");

            migrationBuilder.CreateIndex(
                name: "IX_zalbi_parking_id",
                schema: "INDO_183284_183269",
                table: "zalbi",
                column: "parking_id");

            migrationBuilder.AddForeignKey(
                name: "FK_parking_grad_Grad_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Grad_Id",
                principalSchema: "INDO_183284_183269",
                principalTable: "grad",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_sopstvenik_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Sopstvenik_Id",
                principalSchema: "INDO_183284_183269",
                principalTable: "sopstvenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_zona_Zona_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Zona_Id",
                principalSchema: "INDO_183284_183269",
                principalTable: "zona",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parking_grad_Grad_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_sopstvenik_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_zona_Zona_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropTable(
                name: "grad",
                schema: "INDO_183284_183269");

            migrationBuilder.DropTable(
                name: "zalbi",
                schema: "INDO_183284_183269");

            migrationBuilder.DropTable(
                name: "zona",
                schema: "INDO_183284_183269");

            migrationBuilder.DropPrimaryKey(
                name: "PK_parking",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropIndex(
                name: "IX_parking_Grad_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropIndex(
                name: "IX_parking_Zona_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.RenameTable(
                name: "parking",
                schema: "INDO_183284_183269",
                newName: "Parking",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameIndex(
                name: "IX_parking_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "Parking",
                newName: "IX_Parking_Sopstvenik_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parking",
                schema: "INDO_183284_183269",
                table: "Parking",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Parking_sopstvenik_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "Parking",
                column: "Sopstvenik_Id",
                principalSchema: "INDO_183284_183269",
                principalTable: "sopstvenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
