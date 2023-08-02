using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Posts.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "cat_id",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "auth_id",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_auth_id",
                table: "Posts",
                column: "auth_id");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_cat_id",
                table: "Posts",
                column: "cat_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Authors_auth_id",
                table: "Posts",
                column: "auth_id",
                principalTable: "Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Categories_cat_id",
                table: "Posts",
                column: "cat_id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Authors_auth_id",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Categories_cat_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_auth_id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_cat_id",
                table: "Posts");

            migrationBuilder.AlterColumn<string>(
                name: "cat_id",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "auth_id",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
