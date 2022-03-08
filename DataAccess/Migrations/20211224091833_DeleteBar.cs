using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class DeleteBar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Barcodes",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barcodes",
                table: "Barcodes");

            migrationBuilder.DropColumn(
                name: "StockID",
                table: "Barcodes");

            migrationBuilder.RenameTable(
                name: "Barcodes",
                newName: "Barcode");

            migrationBuilder.RenameColumn(
                name: "BarcodeID",
                table: "Stocks",
                newName: "BarcodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_BarcodeID",
                table: "Stocks",
                newName: "IX_Stocks_BarcodeId");

            migrationBuilder.RenameColumn(
                name: "BarcodeID",
                table: "Barcode",
                newName: "BarcodeId");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Barcode",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barcode",
                table: "Barcode",
                column: "BarcodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Barcode_BarcodeId",
                table: "Stocks",
                column: "BarcodeId",
                principalTable: "Barcode",
                principalColumn: "BarcodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Barcode_BarcodeId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barcode",
                table: "Barcode");

            migrationBuilder.RenameTable(
                name: "Barcode",
                newName: "Barcodes");

            migrationBuilder.RenameColumn(
                name: "BarcodeId",
                table: "Stocks",
                newName: "BarcodeID");

            migrationBuilder.RenameIndex(
                name: "IX_Stocks_BarcodeId",
                table: "Stocks",
                newName: "IX_Stocks_BarcodeID");

            migrationBuilder.RenameColumn(
                name: "BarcodeId",
                table: "Barcodes",
                newName: "BarcodeID");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Barcodes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StockID",
                table: "Barcodes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barcodes",
                table: "Barcodes",
                column: "BarcodeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Barcodes",
                table: "Stocks",
                column: "BarcodeID",
                principalTable: "Barcodes",
                principalColumn: "BarcodeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
