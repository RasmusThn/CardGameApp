using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardGameApi.Migrations
{
    public partial class initialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_HandHistories_HandHistoryId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_HandHistoryId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "HandHistoryId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "CardIdFive",
                table: "HandHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardIdFour",
                table: "HandHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardIdOne",
                table: "HandHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardIdThree",
                table: "HandHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CardIdTwo",
                table: "HandHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Round",
                table: "HandHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardIdFive",
                table: "HandHistories");

            migrationBuilder.DropColumn(
                name: "CardIdFour",
                table: "HandHistories");

            migrationBuilder.DropColumn(
                name: "CardIdOne",
                table: "HandHistories");

            migrationBuilder.DropColumn(
                name: "CardIdThree",
                table: "HandHistories");

            migrationBuilder.DropColumn(
                name: "CardIdTwo",
                table: "HandHistories");

            migrationBuilder.DropColumn(
                name: "Round",
                table: "HandHistories");

            migrationBuilder.AddColumn<int>(
                name: "HandHistoryId",
                table: "Cards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_HandHistoryId",
                table: "Cards",
                column: "HandHistoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_HandHistories_HandHistoryId",
                table: "Cards",
                column: "HandHistoryId",
                principalTable: "HandHistories",
                principalColumn: "Id");
        }
    }
}
