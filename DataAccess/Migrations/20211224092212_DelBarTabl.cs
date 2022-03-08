using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class DelBarTabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Barcode_BarcodeId",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "Barcode");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_BarcodeId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "BarcodeId",
                table: "Stocks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BarcodeId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Barcode",
                columns: table => new
                {
                    BarcodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barcode", x => x.BarcodeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_BarcodeId",
                table: "Stocks",
                column: "BarcodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Barcode_BarcodeId",
                table: "Stocks",
                column: "BarcodeId",
                principalTable: "Barcode",
                principalColumn: "BarcodeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
