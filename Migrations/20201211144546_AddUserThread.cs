using Microsoft.EntityFrameworkCore.Migrations;

namespace gloryhall.Migrations
{
    public partial class AddUserThread : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Thread",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Thread_userId",
                table: "Thread",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Thread_AspNetUsers_userId",
                table: "Thread",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Thread_AspNetUsers_userId",
                table: "Thread");

            migrationBuilder.DropIndex(
                name: "IX_Thread_userId",
                table: "Thread");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Thread");
        }
    }
}
