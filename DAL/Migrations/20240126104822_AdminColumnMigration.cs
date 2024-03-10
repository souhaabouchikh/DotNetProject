using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdminColumnMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_Book_Categories_CategoryId",
                table: "T_Book");

            migrationBuilder.DropIndex(
                name: "IX_T_Book_CategoryId",
                table: "T_Book");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "T_Book");

            migrationBuilder.AddColumn<bool>(
                name: "isAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "T_Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_Book_CategoryId",
                table: "T_Book",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_Book_Categories_CategoryId",
                table: "T_Book",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
