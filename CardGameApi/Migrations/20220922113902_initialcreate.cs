using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardGameApi.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Suit = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HandHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Round = table.Column<int>(type: "int", nullable: false),
                    CardIdOne = table.Column<int>(type: "int", nullable: false),
                    CardIdTwo = table.Column<int>(type: "int", nullable: false),
                    CardIdThree = table.Column<int>(type: "int", nullable: false),
                    CardIdFour = table.Column<int>(type: "int", nullable: false),
                    CardIdFive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandHistories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "ImgUrl", "IsActive", "Number", "Suit" },
                values: new object[,]
                {
                    { 1, "/images/hearts/ace.png", false, 14, 0 },
                    { 2, "/images/hearts/2.png", false, 2, 0 },
                    { 3, "/images/hearts/3.png", false, 3, 0 },
                    { 4, "/images/hearts/4.png", false, 4, 0 },
                    { 5, "/images/hearts/5.png", false, 5, 0 },
                    { 6, "/images/hearts/6.png", false, 6, 0 },
                    { 7, "/images/hearts/7.png", false, 7, 0 },
                    { 8, "/images/hearts/8.png", false, 8, 0 },
                    { 9, "/images/hearts/9.png", false, 9, 0 },
                    { 10, "/images/hearts/10.png", false, 10, 0 },
                    { 11, "/images/hearts/jack.png", false, 11, 0 },
                    { 12, "/images/hearts/queen.png", false, 12, 0 },
                    { 13, "/images/hearts/king.png", false, 13, 0 },
                    { 14, "/images/diamonds/ace.png", false, 14, 2 },
                    { 15, "/images/diamonds/2.png", false, 2, 2 },
                    { 16, "/images/diamonds/3.png", false, 3, 2 },
                    { 17, "/images/diamonds/4.png", false, 4, 2 },
                    { 18, "/images/diamonds/5.png", false, 5, 2 },
                    { 19, "/images/diamonds/6.png", false, 6, 2 },
                    { 20, "/images/diamonds/7.png", false, 7, 2 },
                    { 21, "/images/diamonds/8.png", false, 8, 2 },
                    { 22, "/images/diamonds/9.png", false, 9, 2 },
                    { 23, "/images/diamonds/10.png", false, 10, 2 },
                    { 24, "/images/diamonds/jack.png", false, 11, 2 },
                    { 25, "/images/diamonds/queen.png", false, 12, 2 },
                    { 26, "/images/diamonds/king.png", false, 13, 2 },
                    { 27, "/images/spades/ace.png", false, 14, 3 },
                    { 28, "/images/spades/2.png", false, 2, 3 },
                    { 29, "/images/spades/3.png", false, 3, 3 },
                    { 30, "/images/spades/4.png", false, 4, 3 },
                    { 31, "/images/spades/5.png", false, 5, 3 },
                    { 32, "/images/spades/6.png", false, 6, 3 },
                    { 33, "/images/spades/7.png", false, 7, 3 },
                    { 34, "/images/spades/8.png", false, 8, 3 },
                    { 35, "/images/spades/9.png", false, 9, 3 },
                    { 36, "/images/spades/10.png", false, 10, 3 },
                    { 37, "/images/spades/jack.png", false, 11, 3 },
                    { 38, "/images/spades/queen.png", false, 12, 3 },
                    { 39, "/images/spades/king.png", false, 13, 3 },
                    { 40, "/images/clubs/ace.png", false, 14, 1 },
                    { 41, "/images/clubs/2.png", false, 2, 1 },
                    { 42, "/images/clubs/3.png", false, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "ImgUrl", "IsActive", "Number", "Suit" },
                values: new object[,]
                {
                    { 43, "/images/clubs/4.png", false, 4, 1 },
                    { 44, "/images/clubs/5.png", false, 5, 1 },
                    { 45, "/images/clubs/6.png", false, 6, 1 },
                    { 46, "/images/clubs/7.png", false, 7, 1 },
                    { 47, "/images/clubs/8.png", false, 8, 1 },
                    { 48, "/images/clubs/9.png", false, 9, 1 },
                    { 49, "/images/clubs/10.png", false, 10, 1 },
                    { 50, "/images/clubs/jack.png", false, 11, 1 },
                    { 51, "/images/clubs/queen.png", false, 12, 1 },
                    { 52, "/images/clubs/king.png", false, 13, 1 }
                });
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
