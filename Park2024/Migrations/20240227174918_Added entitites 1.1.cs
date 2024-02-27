using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Park2024.Migrations
{
    /// <inheritdoc />
    public partial class Addedentitites11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_zalbi_korisnik_korisnik_id",
                schema: "INDO_183284_183269",
                table: "zalbi");

            migrationBuilder.DropForeignKey(
                name: "FK_zalbi_parking_parking_id",
                schema: "INDO_183284_183269",
                table: "zalbi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zona",
                schema: "INDO_183284_183269",
                table: "zona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_zalbi",
                schema: "INDO_183284_183269",
                table: "zalbi");

            migrationBuilder.DropIndex(
                name: "IX_zalbi_parking_id",
                schema: "INDO_183284_183269",
                table: "zalbi");

            migrationBuilder.DropIndex(
                name: "IX_parking_Grad_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropIndex(
                name: "IX_parking_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropIndex(
                name: "IX_parking_Zona_Id",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grad",
                schema: "INDO_183284_183269",
                table: "grad");

            migrationBuilder.RenameTable(
                name: "zona",
                schema: "INDO_183284_183269",
                newName: "Zona",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "zalbi",
                schema: "INDO_183284_183269",
                newName: "Zalbi",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "grad",
                schema: "INDO_183284_183269",
                newName: "Grad",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameIndex(
                name: "IX_zalbi_korisnik_id",
                schema: "INDO_183284_183269",
                table: "Zalbi",
                newName: "IX_Zalbi_korisnik_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "INDO_183284_183269",
                table: "parking",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "ParkingId",
                schema: "INDO_183284_183269",
                table: "Zalbi",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gradid",
                schema: "INDO_183284_183269",
                table: "parking",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SopstvenikId",
                schema: "INDO_183284_183269",
                table: "parking",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Zonaid",
                schema: "INDO_183284_183269",
                table: "parking",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zona",
                schema: "INDO_183284_183269",
                table: "Zona",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zalbi",
                schema: "INDO_183284_183269",
                table: "Zalbi",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grad",
                schema: "INDO_183284_183269",
                table: "Grad",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_Zalbi_ParkingId",
                schema: "INDO_183284_183269",
                table: "Zalbi",
                column: "ParkingId");

            migrationBuilder.CreateIndex(
                name: "IX_parking_Gradid",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Gradid");

            migrationBuilder.CreateIndex(
                name: "IX_parking_SopstvenikId",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "SopstvenikId");

            migrationBuilder.CreateIndex(
                name: "IX_parking_Zonaid",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Zonaid");

            migrationBuilder.AddForeignKey(
                name: "FK_parking_Grad_Gradid",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Gradid",
                principalSchema: "INDO_183284_183269",
                principalTable: "Grad",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_Zona_Zonaid",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Zonaid",
                principalSchema: "INDO_183284_183269",
                principalTable: "Zona",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_parking_sopstvenik_SopstvenikId",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "SopstvenikId",
                principalSchema: "INDO_183284_183269",
                principalTable: "sopstvenik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zalbi_korisnik_korisnik_id",
                schema: "INDO_183284_183269",
                table: "Zalbi",
                column: "korisnik_id",
                principalSchema: "INDO_183284_183269",
                principalTable: "korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zalbi_parking_ParkingId",
                schema: "INDO_183284_183269",
                table: "Zalbi",
                column: "ParkingId",
                principalSchema: "INDO_183284_183269",
                principalTable: "parking",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_parking_Grad_Gradid",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_Zona_Zonaid",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropForeignKey(
                name: "FK_parking_sopstvenik_SopstvenikId",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropForeignKey(
                name: "FK_Zalbi_korisnik_korisnik_id",
                schema: "INDO_183284_183269",
                table: "Zalbi");

            migrationBuilder.DropForeignKey(
                name: "FK_Zalbi_parking_ParkingId",
                schema: "INDO_183284_183269",
                table: "Zalbi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zona",
                schema: "INDO_183284_183269",
                table: "Zona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zalbi",
                schema: "INDO_183284_183269",
                table: "Zalbi");

            migrationBuilder.DropIndex(
                name: "IX_Zalbi_ParkingId",
                schema: "INDO_183284_183269",
                table: "Zalbi");

            migrationBuilder.DropIndex(
                name: "IX_parking_Gradid",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropIndex(
                name: "IX_parking_SopstvenikId",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropIndex(
                name: "IX_parking_Zonaid",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grad",
                schema: "INDO_183284_183269",
                table: "Grad");

            migrationBuilder.DropColumn(
                name: "ParkingId",
                schema: "INDO_183284_183269",
                table: "Zalbi");

            migrationBuilder.DropColumn(
                name: "Gradid",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropColumn(
                name: "SopstvenikId",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.DropColumn(
                name: "Zonaid",
                schema: "INDO_183284_183269",
                table: "parking");

            migrationBuilder.RenameTable(
                name: "Zona",
                schema: "INDO_183284_183269",
                newName: "zona",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "Zalbi",
                schema: "INDO_183284_183269",
                newName: "zalbi",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameTable(
                name: "Grad",
                schema: "INDO_183284_183269",
                newName: "grad",
                newSchema: "INDO_183284_183269");

            migrationBuilder.RenameIndex(
                name: "IX_Zalbi_korisnik_id",
                schema: "INDO_183284_183269",
                table: "zalbi",
                newName: "IX_zalbi_korisnik_id");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "INDO_183284_183269",
                table: "parking",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zona",
                schema: "INDO_183284_183269",
                table: "zona",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_zalbi",
                schema: "INDO_183284_183269",
                table: "zalbi",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grad",
                schema: "INDO_183284_183269",
                table: "grad",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_zalbi_parking_id",
                schema: "INDO_183284_183269",
                table: "zalbi",
                column: "parking_id");

            migrationBuilder.CreateIndex(
                name: "IX_parking_Grad_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Grad_Id");

            migrationBuilder.CreateIndex(
                name: "IX_parking_Sopstvenik_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Sopstvenik_Id");

            migrationBuilder.CreateIndex(
                name: "IX_parking_Zona_Id",
                schema: "INDO_183284_183269",
                table: "parking",
                column: "Zona_Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_zalbi_korisnik_korisnik_id",
                schema: "INDO_183284_183269",
                table: "zalbi",
                column: "korisnik_id",
                principalSchema: "INDO_183284_183269",
                principalTable: "korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_zalbi_parking_parking_id",
                schema: "INDO_183284_183269",
                table: "zalbi",
                column: "parking_id",
                principalSchema: "INDO_183284_183269",
                principalTable: "parking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
