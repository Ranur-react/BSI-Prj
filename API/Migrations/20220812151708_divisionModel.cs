using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class divisionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DivisionId",
                table: "Tb_M_Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tb_M_Divions",
                columns: table => new
                {
                    IdDivision = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Divions", x => x.IdDivision);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_M_Employees_DivisionId",
                table: "Tb_M_Employees",
                column: "DivisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tb_M_Employees_Tb_M_Divions_DivisionId",
                table: "Tb_M_Employees",
                column: "DivisionId",
                principalTable: "Tb_M_Divions",
                principalColumn: "IdDivision",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tb_M_Employees_Tb_M_Divions_DivisionId",
                table: "Tb_M_Employees");

            migrationBuilder.DropTable(
                name: "Tb_M_Divions");

            migrationBuilder.DropIndex(
                name: "IX_Tb_M_Employees_DivisionId",
                table: "Tb_M_Employees");

            migrationBuilder.DropColumn(
                name: "DivisionId",
                table: "Tb_M_Employees");
        }
    }
}
