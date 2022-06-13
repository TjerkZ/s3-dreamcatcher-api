using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace s3_dreamcatcher_api.dal.Migrations
{
    public partial class AddUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Dreams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Dreams");
        }
    }
}
