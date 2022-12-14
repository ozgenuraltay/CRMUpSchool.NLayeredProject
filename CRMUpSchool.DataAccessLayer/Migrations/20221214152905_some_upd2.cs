using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMUpSchool.DataAccessLayer.Migrations
{
    public partial class some_upd2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserId",
                table: "EmployeeTasks");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "EmployeeTasks",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTasks_AppUserId",
                table: "EmployeeTasks",
                newName: "IX_EmployeeTasks_AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserID",
                table: "EmployeeTasks",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserID",
                table: "EmployeeTasks");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "EmployeeTasks",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTasks_AppUserID",
                table: "EmployeeTasks",
                newName: "IX_EmployeeTasks_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserId",
                table: "EmployeeTasks",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
