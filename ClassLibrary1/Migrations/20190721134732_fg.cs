using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class fg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__users__users_InvitedById",
                table: "_users");

            migrationBuilder.DropForeignKey(
                name: "FK_Suggests__users_AuthorId",
                table: "Suggests");

            migrationBuilder.DropPrimaryKey(
                name: "PK__users",
                table: "_users");

            migrationBuilder.RenameTable(
                name: "_users",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX__users_InvitedById",
                table: "Users",
                newName: "IX_Users_InvitedById");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suggests_Users_AuthorId",
                table: "Suggests",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_InvitedById",
                table: "Users",
                column: "InvitedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suggests_Users_AuthorId",
                table: "Suggests");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_InvitedById",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "_users");

            migrationBuilder.RenameIndex(
                name: "IX_Users_InvitedById",
                table: "_users",
                newName: "IX__users_InvitedById");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "_users",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK__users",
                table: "_users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__users__users_InvitedById",
                table: "_users",
                column: "InvitedById",
                principalTable: "_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Suggests__users_AuthorId",
                table: "Suggests",
                column: "AuthorId",
                principalTable: "_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
