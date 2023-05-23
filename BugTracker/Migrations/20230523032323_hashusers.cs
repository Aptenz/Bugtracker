using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugTracker.Migrations
{
    public partial class hashusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_AspNetUsers_AppUserID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_AppUserID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_AppUserID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Projects_AppUserID",
                table: "Projects");

            migrationBuilder.CreateTable(
                name: "AppUserProject",
                columns: table => new
                {
                    AppUsersId = table.Column<string>(type: "text", nullable: false),
                    ProjectsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserProject", x => new { x.AppUsersId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_AppUserProject_AspNetUsers_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserTicket",
                columns: table => new
                {
                    AppUsersId = table.Column<string>(type: "text", nullable: false),
                    TicketsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTicket", x => new { x.AppUsersId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_AppUserTicket_AspNetUsers_AppUsersId",
                        column: x => x.AppUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserProject_ProjectsId",
                table: "AppUserProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserTicket_TicketsId",
                table: "AppUserTicket",
                column: "TicketsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserProject");

            migrationBuilder.DropTable(
                name: "AppUserTicket");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AppUserID",
                table: "Tickets",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AppUserID",
                table: "Projects",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_AspNetUsers_AppUserID",
                table: "Projects",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_AppUserID",
                table: "Tickets",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
