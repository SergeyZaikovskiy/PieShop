using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class UpdateDecimalFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPieOfTheWeek",
                table: "Pies",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPieOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsPieOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsPieOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsPieOfTheWeek",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "IsPieOfTheWeek",
                table: "Pies",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsPieOfTheWeek",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsPieOfTheWeek",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsPieOfTheWeek",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsPieOfTheWeek",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsPieOfTheWeek",
                value: 0m);
        }
    }
}
