using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDMIMudblazorProject.Migrations
{
    /// <inheritdoc />
    public partial class ïnitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    HireDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JobTitle = table.Column<string>(type: "TEXT", nullable: false),
                    Salary = table.Column<double>(type: "REAL", nullable: false),
                    DepartmentName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DepartmentName", "Email", "FirstName", "HireDate", "JobTitle", "LastName", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 1001, "Internal", "testEmail@gmail.com", "Andrew", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4081), "Senior Dev", "Tate", "+639521087463", 60000.0 },
                    { 1002, "Internal", "testEmail@gmail.com", "Tiger", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4097), "Senior Dev", "Woods", "+639521087463", 60000.0 },
                    { 1003, "Internal", "testEmail@gmail.com", "Prince", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4098), "Senior Dev", "Charles", "+639521087463", 60000.0 },
                    { 1004, "Internal", "testEmail@gmail.com", "John", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4100), "Senior Dev", "Wick", "+639521087463", 60000.0 },
                    { 1005, "Internal", "testEmail@gmail.com", "Nice", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4101), "Senior Dev", "Guy", "+639521087463", 60000.0 },
                    { 1006, "Internal", "testEmail@gmail.com", "Nate", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4104), "Senior Dev", "Diaz", "+639521087463", 60000.0 },
                    { 1007, "Internal", "testEmail@gmail.com", "Lionel", new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4105), "Senior Dev", "Messi", "+639521087463", 60000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
