using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class AddPieWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "Pies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1200.95m, 1.5m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1800.95m, 2.3m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1800.95m, 2.5m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1500.95m, 1.8m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1300.95m, 1.5m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1700.95m, 2.6m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1500.95m, 1.3m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1200.95m, 1.0m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1500.95m, 2.0m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1500.95m, 2.2m });

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Price", "Weight" },
                values: new object[] { 1800.95m, 3.3m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Pies");

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
    }
}
