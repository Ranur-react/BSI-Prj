// <auto-generated />
using System;
using API.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220813175706_new model for vehicle")]
    partial class newmodelforvehicle
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiredToken")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Last_online")
                        .HasColumnType("datetime2");

                    b.Property<int>("OTP")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Tb_M_Accounts");
                });

            modelBuilder.Entity("API.Models.Division", b =>
                {
                    b.Property<string>("IdDivision")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DivisionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDivision");

                    b.ToTable("Tb_M_Divions");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DivisionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Tb_M_Employees");
                });

            modelBuilder.Entity("API.Models.Pesanan", b =>
                {
                    b.Property<string>("IdPesanan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Deskripsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LokasiAwal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LokasiTujuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoPlat")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("TanggalPesanan")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPesanan");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("NoPlat");

                    b.ToTable("Tb_T_Pesanan");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tb_M_Roles");
                });

            modelBuilder.Entity("API.Models.Vehicle", b =>
                {
                    b.Property<string>("NoPlat")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Capity")
                        .HasColumnType("int");

                    b.Property<string>("CarBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearProductions")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("NoPlat");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Tb_M_Vehicle");
                });

            modelBuilder.Entity("API.Models.VehicleType", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdType");

                    b.ToTable("Tb_M_VehicleType");
                });

            modelBuilder.Entity("API.Models.Account", b =>
                {
                    b.HasOne("API.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Models.Employee", "Employee")
                        .WithOne("Accounts")
                        .HasForeignKey("API.Models.Account", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.HasOne("API.Models.Division", "Division")
                        .WithMany("Employee")
                        .HasForeignKey("DivisionId");

                    b.Navigation("Division");
                });

            modelBuilder.Entity("API.Models.Pesanan", b =>
                {
                    b.HasOne("API.Models.Employee", "Employee")
                        .WithMany("Pesanan")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("API.Models.Vehicle", "Vehicle")
                        .WithMany("Pesanan")
                        .HasForeignKey("NoPlat");

                    b.Navigation("Employee");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("API.Models.Vehicle", b =>
                {
                    b.HasOne("API.Models.VehicleType", "VehicleType")
                        .WithMany("Vehicles")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VehicleType");
                });

            modelBuilder.Entity("API.Models.Division", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("API.Models.Employee", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Pesanan");
                });

            modelBuilder.Entity("API.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("API.Models.Vehicle", b =>
                {
                    b.Navigation("Pesanan");
                });

            modelBuilder.Entity("API.Models.VehicleType", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
