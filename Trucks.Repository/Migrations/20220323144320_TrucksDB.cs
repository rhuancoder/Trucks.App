using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trucks.Repository.Migrations
{
    public partial class TrucksDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_TRUCK_MODEL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NAME = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TRUCK_MODEL", x => x.ID);
                });

            migrationBuilder.InsertData(
               table: "TB_TRUCK_MODEL",
               columns: new[] { "ID", "NAME" },
               values: new object[] { 1, "FH" });

            migrationBuilder.InsertData(
                table: "TB_TRUCK_MODEL",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 2, "FM" });

            migrationBuilder.CreateTable(
                name: "TB_TRUCK",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ID_TRUCK_MODEL = table.Column<int>(type: "INTEGER", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    COLOR = table.Column<string>(type: "VARCHAR(30)", nullable: false),
                    MANUFACTURE_YEAR = table.Column<int>(type: "INTEGER", nullable: false),
                    MODEL_YEAR = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TRUCK", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TRUCK_TRUCK_MODEL",
                        column: x => x.ID_TRUCK_MODEL,
                        principalTable: "TB_TRUCK_MODEL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_TRUCK",
                columns: new[] { "ID", "ID_TRUCK_MODEL", "NAME", "COLOR", "MANUFACTURE_YEAR", "MODEL_YEAR" },
                values: new object[] { 1, 2, "Xpto", "white", 2018, 2022 });

            migrationBuilder.InsertData(
                table: "TB_TRUCK",
                columns: new[] { "ID", "ID_TRUCK_MODEL", "NAME", "COLOR", "MANUFACTURE_YEAR", "MODEL_YEAR" },
                values: new object[] { 2, 1, "Asdf", "black", 2019, 2022 });

            migrationBuilder.CreateIndex(
                name: "IX_TB_TRUCK_ID_TRUCK_MODEL",
                table: "TB_TRUCK",
                column: "ID_TRUCK_MODEL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_TRUCK");

            migrationBuilder.DropTable(
                name: "TB_TRUCK_MODEL");
        }
    }
}
