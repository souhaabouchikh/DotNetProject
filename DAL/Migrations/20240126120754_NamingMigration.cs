using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class NamingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_Users_UserId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBook_T_Book_BookId",
                table: "FavoriteBook");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Book_Categories_CategoryId",
                table: "T_Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteBook",
                table: "FavoriteBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "T_User");

            migrationBuilder.RenameTable(
                name: "FavoriteBook",
                newName: "T_FavoriteBook");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "T_Category");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteBook_BookId",
                table: "T_FavoriteBook",
                newName: "IX_T_FavoriteBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_User",
                table: "T_User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_FavoriteBook",
                table: "T_FavoriteBook",
                column: "FavoriteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Category",
                table: "T_Category",
                column: "Id");

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
                name: "FK_T_FavoriteBook_T_Book_BookId",
                table: "T_FavoriteBook",
                column: "BookId",
                principalTable: "T_Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_T_User_UserId",
                table: "Favorite");

            migrationBuilder.DropForeignKey(
                name: "FK_T_Book_T_Category_CategoryId",
                table: "T_Book");

            migrationBuilder.DropForeignKey(
                name: "FK_T_FavoriteBook_T_Book_BookId",
                table: "T_FavoriteBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_User",
                table: "T_User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_FavoriteBook",
                table: "T_FavoriteBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Category",
                table: "T_Category");

            migrationBuilder.RenameTable(
                name: "T_User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "T_FavoriteBook",
                newName: "FavoriteBook");

            migrationBuilder.RenameTable(
                name: "T_Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_T_FavoriteBook_BookId",
                table: "FavoriteBook",
                newName: "IX_FavoriteBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteBook",
                table: "FavoriteBook",
                column: "FavoriteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_Users_UserId",
                table: "Favorite",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBook_T_Book_BookId",
                table: "FavoriteBook",
                column: "BookId",
                principalTable: "T_Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_T_Book_Categories_CategoryId",
                table: "T_Book",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
