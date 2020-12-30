using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gloryhall.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tournament = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    team1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    team2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scoresTeam1 = table.Column<short>(type: "smallint", nullable: false),
                    scoresTeam2 = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Thread",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    matchid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thread", x => x.id);
                    table.ForeignKey(
                        name: "FK_Thread_Match_matchid",
                        column: x => x.matchid,
                        principalTable: "Match",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idThread = table.Column<int>(type: "int", nullable: false),
                    Threadid = table.Column<int>(type: "int", nullable: true),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.id);
                    table.ForeignKey(
                        name: "FK_messages_Thread_Threadid",
                        column: x => x.Threadid,
                        principalTable: "Thread",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_messages_Threadid",
                table: "messages",
                column: "Threadid");

            migrationBuilder.CreateIndex(
                name: "IX_Thread_matchid",
                table: "Thread",
                column: "matchid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "Thread");

            migrationBuilder.DropTable(
                name: "Match");
        }
    }
}
