using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class ChangePiePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 120.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 180.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 180.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 150.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 130.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 170.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 150.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 120.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 150.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 150.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 180.95m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 12.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 18.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 18.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 15.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 13.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 17.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 15.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 12.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 15.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 15.95m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Price",
                value: 18.95m);
        }
    }
}
