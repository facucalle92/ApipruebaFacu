using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiFacu.WebAPi.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesionales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomApellProf = table.Column<string>(nullable: false),
                    Especialidad = table.Column<string>(nullable: false),
                    DniProf = table.Column<int>(nullable: false),
                    Nacionalidad = table.Column<string>(nullable: false),
                    Provincia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesionales");
        }
    }
}
