using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class OneQ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailId",
                table: "Users",
                column: "EmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Emails_EmailId",
                table: "Users",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Emails_EmailId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_EmailId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Users");
        }
    }
}
