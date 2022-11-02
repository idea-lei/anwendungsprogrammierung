using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FahrtenbuchWeb.Data.Migrations
{
    public partial class verbrauch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "verbrauchModels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FZ_ID = table.Column<int>(type: "int", nullable: false),
                    Km_Stand = table.Column<double>(type: "float", nullable: false),
                    Km = table.Column<double>(type: "float", nullable: false),
                    Verbrauch = table.Column<double>(type: "float", nullable: false),
                    V_Km = table.Column<double>(type: "float", nullable: false),
                    V_Mpg = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_verbrauchModels", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "verbrauchModels");
        }
    }
}
