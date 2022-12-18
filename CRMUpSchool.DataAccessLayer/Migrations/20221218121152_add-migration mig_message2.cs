using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMUpSchool.DataAccessLayer.Migrations
{
    public partial class addmigrationmig_message2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageContent",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "Messages");
        }
    }
}
