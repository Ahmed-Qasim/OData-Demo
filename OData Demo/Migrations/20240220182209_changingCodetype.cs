using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OData_Demo.Migrations
{
    /// <inheritdoc />
    public partial class changingCodetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { 234, new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { 235, new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { 236, new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { 237, new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(7043) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { "234", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { "235", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { "236", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "HiringDate" },
                values: new object[] { "237", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(71) });
        }
    }
}
