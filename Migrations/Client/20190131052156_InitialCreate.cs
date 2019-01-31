using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Migrations.Client
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CoName = table.Column<string>(nullable: true),
                    CoPhone = table.Column<string>(nullable: true),
                    Liaison = table.Column<string>(nullable: true),
                    LiaisonPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
