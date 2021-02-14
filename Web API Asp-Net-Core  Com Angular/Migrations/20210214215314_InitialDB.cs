using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_API_Asp_Net_Core__Com_Angular.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banco",
                columns: table => new
                {
                    BancoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BancoNome = table.Column<string>(type: "nvarchar(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banco", x => x.BancoId);
                });

            migrationBuilder.CreateTable(
                name: "BancoConta",
                columns: table => new
                {
                    BancoContaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContaNumero = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    ContaSeguradora = table.Column<string>(type: "nvarchar(150)", nullable: false),
                    BancoId = table.Column<int>(type: "int", nullable: false),
                    BRFSC = table.Column<string>(type: "nvarchar(25)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BancoConta", x => x.BancoContaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banco");

            migrationBuilder.DropTable(
                name: "BancoConta");
        }
    }
}
