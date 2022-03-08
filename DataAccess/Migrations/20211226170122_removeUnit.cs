using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class removeUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Units",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_UnitID",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "UnitID",
                table: "Stocks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitID",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_UnitID",
                table: "Stocks",
                column: "UnitID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Units",
                table: "Stocks",
                column: "UnitID",
                principalTable: "Units",
                principalColumn: "UnitID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
