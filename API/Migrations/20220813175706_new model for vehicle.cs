using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class newmodelforvehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_M_VehicleType",
                columns: table => new
                {
                    IdType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_VehicleType", x => x.IdType);
                });

            migrationBuilder.CreateTable(
                name: "Tb_M_Vehicle",
                columns: table => new
                {
                    NoPlat = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capity = table.Column<int>(type: "int", nullable: false),
                    YearProductions = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarTypeId = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Vehicle", x => x.NoPlat);
                    table.ForeignKey(
                        name: "FK_Tb_M_Vehicle_Tb_M_VehicleType_CarTypeId",
                        column: x => x.CarTypeId,
                        principalTable: "Tb_M_VehicleType",
                        principalColumn: "IdType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_T_Pesanan",
                columns: table => new
                {
                    IdPesanan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NoPlat = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TanggalPesanan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LokasiAwal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LokasiTujuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deskripsi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_T_Pesanan", x => x.IdPesanan);
                    table.ForeignKey(
                        name: "FK_Tb_T_Pesanan_Tb_M_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Tb_M_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tb_T_Pesanan_Tb_M_Vehicle_NoPlat",
                        column: x => x.NoPlat,
                        principalTable: "Tb_M_Vehicle",
                        principalColumn: "NoPlat",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_M_Vehicle_CarTypeId",
                table: "Tb_M_Vehicle",
                column: "CarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_T_Pesanan_EmployeeId",
                table: "Tb_T_Pesanan",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_T_Pesanan_NoPlat",
                table: "Tb_T_Pesanan",
                column: "NoPlat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_T_Pesanan");

            migrationBuilder.DropTable(
                name: "Tb_M_Vehicle");

            migrationBuilder.DropTable(
                name: "Tb_M_VehicleType");
        }
    }
}
