using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardGameApi.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HandHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandHistories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Suit = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HandHistoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_HandHistories_HandHistoryId",
                        column: x => x.HandHistoryId,
                        principalTable: "HandHistories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "HandHistoryId", "ImgUrl", "IsActive", "Number", "Suit" },
                values: new object[,]
                {
                    { 1, null, "/images/hearts/ace.png", true, 14, 0 },
                    { 2, null, "/images/hearts/2.png", true, 2, 0 },
                    { 3, null, "/images/hearts/3.png", true, 3, 0 },
                    { 4, null, "/images/hearts/4.png", true, 4, 0 },
                    { 5, null, "/images/hearts/5.png", true, 5, 0 },
                    { 6, null, "/images/hearts/6.png", true, 6, 0 },
                    { 7, null, "/images/hearts/7.png", true, 7, 0 },
                    { 8, null, "/images/hearts/8.png", true, 8, 0 },
                    { 9, null, "/images/hearts/9.png", true, 9, 0 },
                    { 10, null, "/images/hearts/10.png", true, 10, 0 },
                    { 11, null, "/images/hearts/jack.png", true, 11, 0 },
                    { 12, null, "/images/hearts/queen.png", true, 12, 0 },
                    { 13, null, "/images/hearts/king.png", true, 13, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_HandHistoryId",
                table: "Cards",
                column: "HandHistoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "HandHistories");
        }
    }
}
