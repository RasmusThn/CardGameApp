using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardGameApi.Migrations
{
    public partial class finallUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "ImgUrl", "IsActive", "Number", "Suit" },
                values: new object[,]
                {
                    { 14, "/images/diamonds/ace.png", true, 14, 2 },
                    { 15, "/images/diamonds/2.png", true, 2, 2 },
                    { 16, "/images/diamonds/3.png", true, 3, 2 },
                    { 17, "/images/diamonds/4.png", true, 4, 2 },
                    { 18, "/images/diamonds/5.png", true, 5, 2 },
                    { 19, "/images/diamonds/6.png", true, 6, 2 },
                    { 20, "/images/diamonds/7.png", true, 7, 2 },
                    { 21, "/images/diamonds/8.png", true, 8, 2 },
                    { 22, "/images/diamonds/9.png", true, 9, 2 },
                    { 23, "/images/diamonds/10.png", true, 10, 2 },
                    { 24, "/images/diamonds/jack.png", true, 11, 2 },
                    { 25, "/images/diamonds/queen.png", true, 12, 2 },
                    { 26, "/images/diamonds/king.png", true, 13, 2 },
                    { 27, "/images/spades/ace.png", true, 14, 3 },
                    { 28, "/images/spades/2.png", true, 2, 3 },
                    { 29, "/images/spades/3.png", true, 3, 3 },
                    { 30, "/images/spades/4.png", true, 4, 3 },
                    { 31, "/images/spades/5.png", true, 5, 3 },
                    { 32, "/images/spades/6.png", true, 6, 3 },
                    { 33, "/images/spades/7.png", true, 7, 3 },
                    { 34, "/images/spades/8.png", true, 8, 3 },
                    { 35, "/images/spades/9.png", true, 9, 3 },
                    { 36, "/images/spades/10.png", true, 10, 3 },
                    { 37, "/images/spades/jack.png", true, 11, 3 },
                    { 38, "/images/spades/queen.png", true, 12, 3 },
                    { 39, "/images/spades/king.png", true, 13, 3 },
                    { 40, "/images/clubs/ace.png", true, 14, 1 },
                    { 41, "/images/clubs/2.png", true, 2, 1 },
                    { 42, "/images/clubs/3.png", true, 3, 1 },
                    { 43, "/images/clubs/4.png", true, 4, 1 },
                    { 44, "/images/clubs/5.png", true, 5, 1 },
                    { 45, "/images/clubs/6.png", true, 6, 1 },
                    { 46, "/images/clubs/7.png", true, 7, 1 },
                    { 47, "/images/clubs/8.png", true, 8, 1 },
                    { 48, "/images/clubs/9.png", true, 9, 1 },
                    { 49, "/images/clubs/10.png", true, 10, 1 },
                    { 50, "/images/clubs/jack.png", true, 11, 1 },
                    { 51, "/images/clubs/queen.png", true, 12, 1 },
                    { 52, "/images/clubs/king.png", true, 13, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52);
        }
    }
}
