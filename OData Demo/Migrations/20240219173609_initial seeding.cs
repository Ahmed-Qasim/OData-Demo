using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OData_Demo.Migrations
{
    /// <inheritdoc />
    public partial class initialseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaryStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Code", "HiringDate", "JobCode", "Name", "SalaryStatus" },
                values: new object[,]
                {
                    { 1, "234", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(12), "5712", "Ahmed Kassem", "valid" },
                    { 2, "235", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(66), "5712", "Mohamed Kassem", "valid" },
                    { 3, "236", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(69), "5896", "Mazen Ali", "valid" },
                    { 4, "237", new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(71), "5476", "Taha Emad", "unvalid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
