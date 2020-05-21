using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDevPortfolioAPI.Infraestructure.Persistence.Migrations
{
    public partial class seedDocumentTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO DocumentTypes VALUES ('CC','Cedula de Ciudadania','','5/21/2020','','')");
            migrationBuilder.Sql("INSERT INTO DocumentTypes VALUES ('CE','Cedula de Extranjeria','','5/21/2020','','')");
            migrationBuilder.Sql("INSERT INTO DocumentTypes VALUES ('PP','Cedula de Pasaporte','','5/21/2020','','')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("TRUNCATE DocumentTypes");
        }
    }
}
