using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ST_Company.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Offices_Office_id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "WorkingHours",
                table: "EmpProjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Office_id",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Offices_Office_id",
                table: "Employees",
                column: "Office_id",
                principalTable: "Offices",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Offices_Office_id",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "WorkingHours",
                table: "EmpProjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Office_id",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Offices_Office_id",
                table: "Employees",
                column: "Office_id",
                principalTable: "Offices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
