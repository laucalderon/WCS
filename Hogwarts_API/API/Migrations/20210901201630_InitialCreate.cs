using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identificacion = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    CasaSolicitada = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Solicitudes",
                columns: new[] { "Id", "Apellidos", "CasaSolicitada", "Edad", "Identificacion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Lima Barreras", 1, 18, "136", "Carlos" },
                    { 2, "Isequilla", 2, 17, "145", "Josefina" },
                    { 3, "Miranda Ramírez", 3, 20, "150", "Pablo" },
                    { 4, "García Pedroso", 4, 16, "130", "Lidia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solicitudes");
        }
    }
}
