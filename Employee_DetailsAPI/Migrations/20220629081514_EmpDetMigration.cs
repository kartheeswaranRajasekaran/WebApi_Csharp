using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee_DetailsAPI.Migrations
{
    public partial class EmpDetMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTable1",
                columns: table => new
                {
                    EmpId = table.Column<Guid>(nullable: false),
                    EmpName = table.Column<string>(maxLength: 50, nullable: false),
                    EmpPhone = table.Column<string>(nullable: false),
                    EmpEmail = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    JobTitle = table.Column<string>(nullable: false),
                    Department = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTable1", x => x.EmpId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTable1");
        }
    }
}
