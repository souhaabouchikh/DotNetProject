using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class FK3Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBook_FavoriteLists_FavoriteId1",
                table: "FavoriteBook");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteLists_Users_UserId",
                table: "FavoriteLists");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBook_FavoriteId1",
                table: "FavoriteBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteLists",
                table: "FavoriteLists");

            migrationBuilder.DropColumn(
                name: "FavoriteId1",
                table: "FavoriteBook");

            migrationBuilder.RenameTable(
                name: "FavoriteLists",
                newName: "Favorite");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteLists_UserId",
                table: "Favorite",
                newName: "IX_Favorite_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorite",
                table: "Favorite",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorite_Users_UserId",
                table: "Favorite",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorite_Users_UserId",
                table: "Favorite");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorite",
                table: "Favorite");

            migrationBuilder.RenameTable(
                name: "Favorite",
                newName: "FavoriteLists");

            migrationBuilder.RenameIndex(
                name: "IX_Favorite_UserId",
                table: "FavoriteLists",
                newName: "IX_FavoriteLists_UserId");

            migrationBuilder.AddColumn<int>(
                name: "FavoriteId1",
                table: "FavoriteBook",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteLists",
                table: "FavoriteLists",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBook_FavoriteId1",
                table: "FavoriteBook",
                column: "FavoriteId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBook_FavoriteLists_FavoriteId1",
                table: "FavoriteBook",
                column: "FavoriteId1",
                principalTable: "FavoriteLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteLists_Users_UserId",
                table: "FavoriteLists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
