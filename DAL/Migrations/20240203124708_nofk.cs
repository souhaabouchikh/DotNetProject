using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class nofk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_T_User_UserId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Book_T_Category_CategoryId",
                table: "T_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Book_T_Writer_WriterId",
                table: "T_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_T_FavoriteBook_T_Book_BookId",
                table: "T_FavoriteBook");

            migrationBuilder.DropIndex(
                name: "IX_T_FavoriteBook_BookId",
                table: "T_FavoriteBook");

            migrationBuilder.DropIndex(
                name: "IX_T_Book_CategoryId",
                table: "T_Book");

            migrationBuilder.DropIndex(
                name: "IX_T_Book_WriterId",
                table: "T_Book");

            migrationBuilder.DropIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "T_Book");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "T_Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_FavoriteBook_BookId",
                table: "T_FavoriteBook",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Book_CategoryId",
                table: "T_Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Book_WriterId",
                table: "T_Book",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_UserId",
                table: "Favorite",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_T_User_UserId",
                table: "Favorite",
                column: "UserId",
                principalTable: "T_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Book_T_Category_CategoryId",
                table: "T_Book",
                column: "CategoryId",
                principalTable: "T_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Book_T_Writer_WriterId",
                table: "T_Book",
                column: "WriterId",
                principalTable: "T_Writer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_FavoriteBook_T_Book_BookId",
                table: "T_FavoriteBook",
                column: "BookId",
                principalTable: "T_Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
