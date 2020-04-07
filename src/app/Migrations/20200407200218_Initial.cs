using Microsoft.EntityFrameworkCore.Migrations;

namespace Boardgames.ConsoleApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gamedesigners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gamedesigners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boardgames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    MinPlayers = table.Column<int>(nullable: false),
                    MaxPlayers = table.Column<int>(nullable: false),
                    GameDesignerId = table.Column<int>(nullable: false),
                    PlayTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boardgames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boardgames_Gamedesigners_GameDesignerId",
                        column: x => x.GameDesignerId,
                        principalTable: "Gamedesigners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boardgames_GameDesignerId",
                table: "Boardgames",
                column: "GameDesignerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boardgames");

            migrationBuilder.DropTable(
                name: "Gamedesigners");
        }
    }
}
