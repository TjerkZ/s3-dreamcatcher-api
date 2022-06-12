using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace s3_dreamcatcher_api.dal.Migrations
{
    public partial class dto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DreamTag");

            migrationBuilder.AddColumn<int>(
                name: "DreamDTOID",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_DreamDTOID",
                table: "Tags",
                column: "DreamDTOID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Dreams_DreamDTOID",
                table: "Tags",
                column: "DreamDTOID",
                principalTable: "Dreams",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Dreams_DreamDTOID",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_DreamDTOID",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DreamDTOID",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "DreamTag",
                columns: table => new
                {
                    DreamsID = table.Column<int>(type: "int", nullable: false),
                    TagsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DreamTag", x => new { x.DreamsID, x.TagsID });
                    table.ForeignKey(
                        name: "FK_DreamTag_Dreams_DreamsID",
                        column: x => x.DreamsID,
                        principalTable: "Dreams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DreamTag_Tags_TagsID",
                        column: x => x.TagsID,
                        principalTable: "Tags",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DreamTag_TagsID",
                table: "DreamTag",
                column: "TagsID");
        }
    }
}
