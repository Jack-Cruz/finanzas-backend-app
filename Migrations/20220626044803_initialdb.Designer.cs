// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finanzas_backend_app.Data;

#nullable disable

namespace finanzas_backend_app.Migrations
{
    [DbContext(typeof(EasyFinanzasContext))]
    [Migration("20220626044803_initialdb")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("finanzas_backend_app.Models.Bonista", b =>
                {
                    b.Property<int>("idbonista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DNI")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("RUC")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("celular")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("contrasenia")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("correo")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("direccion")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("distrito")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("provincia")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("region")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("usuario")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("idbonista");

                    b.ToTable("Bonistas");
                });

            modelBuilder.Entity("finanzas_backend_app.Models.Bono", b =>
                {
                    b.Property<int>("idbono")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("anios")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("fecemision")
                        .HasColumnType("TEXT");

                    b.Property<int>("frecpago")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idbonista")
                        .HasColumnType("INTEGER");

                    b.Property<float>("imprenta")
                        .HasColumnType("REAL");

                    b.Property<string>("moneda")
                        .HasColumnType("TEXT");

                    b.Property<float>("perccavali")
                        .HasColumnType("REAL");

                    b.Property<float>("perccolocacion")
                        .HasColumnType("REAL");

                    b.Property<float>("percestructuracion")
                        .HasColumnType("REAL");

                    b.Property<float>("percprima")
                        .HasColumnType("REAL");

                    b.Property<float>("tasadescuento")
                        .HasColumnType("REAL");

                    b.Property<float>("tasainteres")
                        .HasColumnType("REAL");

                    b.Property<string>("tipotasa")
                        .HasColumnType("TEXT");

                    b.Property<float>("valcomercial")
                        .HasColumnType("REAL");

                    b.Property<float>("valnominal")
                        .HasColumnType("REAL");

                    b.HasKey("idbono");

                    b.ToTable("Bonos");
                });

            modelBuilder.Entity("finanzas_backend_app.Models.BonoResumen", b =>
                {
                    b.Property<int>("idresumen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("TCEAbonista")
                        .HasColumnType("REAL");

                    b.Property<float>("TCEAemisor")
                        .HasColumnType("REAL");

                    b.Property<float>("convexidad")
                        .HasColumnType("REAL");

                    b.Property<float>("duracion")
                        .HasColumnType("REAL");

                    b.Property<float>("duracionmod")
                        .HasColumnType("REAL");

                    b.Property<float>("total")
                        .HasColumnType("REAL");

                    b.HasKey("idresumen");

                    b.ToTable("BonoResumenes");
                });

            modelBuilder.Entity("finanzas_backend_app.Models.Flujo", b =>
                {
                    b.Property<int>("idflujo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Bonoidbono")
                        .HasColumnType("INTEGER");

                    b.Property<float>("amortizacion")
                        .HasColumnType("REAL");

                    b.Property<float>("bono")
                        .HasColumnType("REAL");

                    b.Property<float>("convexidad")
                        .HasColumnType("REAL");

                    b.Property<float>("cuota")
                        .HasColumnType("REAL");

                    b.Property<float>("escudo")
                        .HasColumnType("REAL");

                    b.Property<float>("faplazo")
                        .HasColumnType("REAL");

                    b.Property<float>("flujoactual")
                        .HasColumnType("REAL");

                    b.Property<float>("flujobonista")
                        .HasColumnType("REAL");

                    b.Property<float>("flujoemisor")
                        .HasColumnType("REAL");

                    b.Property<float>("flujoemisorescudo")
                        .HasColumnType("REAL");

                    b.Property<int>("idbono")
                        .HasColumnType("INTEGER");

                    b.Property<int>("n")
                        .HasColumnType("INTEGER");

                    b.Property<float>("prima")
                        .HasColumnType("REAL");

                    b.HasKey("idflujo");

                    b.HasIndex("Bonoidbono");

                    b.ToTable("Flujos");
                });

            modelBuilder.Entity("finanzas_backend_app.Models.Flujo", b =>
                {
                    b.HasOne("finanzas_backend_app.Models.Bono", null)
                        .WithMany("flujos")
                        .HasForeignKey("Bonoidbono");
                });

            modelBuilder.Entity("finanzas_backend_app.Models.Bono", b =>
                {
                    b.Navigation("flujos");
                });
#pragma warning restore 612, 618
        }
    }
}
