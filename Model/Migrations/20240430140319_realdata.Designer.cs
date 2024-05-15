﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Entities;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(EFKlantenContext))]
    [Migration("20240430140319_realdata")]
    partial class realdata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Entities.Klant", b =>
                {
                    b.Property<int>("KlantNr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KlantNr"));

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KlantNr");

                    b.ToTable("Klanten");

                    b.HasData(
                        new
                        {
                            KlantNr = 1,
                            Voornaam = "Marge"
                        },
                        new
                        {
                            KlantNr = 2,
                            Voornaam = "Homer"
                        },
                        new
                        {
                            KlantNr = 3,
                            Voornaam = "Lisa"
                        },
                        new
                        {
                            KlantNr = 4,
                            Voornaam = "Maggie"
                        },
                        new
                        {
                            KlantNr = 5,
                            Voornaam = "Bart"
                        });
                });

            modelBuilder.Entity("Model.Entities.Rekening", b =>
                {
                    b.Property<string>("RekeningNr")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("KlantNr")
                        .HasColumnType("int");

                    b.Property<decimal>("Saldo")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Soort")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("RekeningNr");

                    b.HasIndex("KlantNr");

                    b.ToTable("Rekeningen");

                    b.HasData(
                        new
                        {
                            RekeningNr = "123-4567890-02",
                            KlantNr = 1,
                            Saldo = 1000m,
                            Soort = "Z"
                        },
                        new
                        {
                            RekeningNr = "234-5678901-69",
                            KlantNr = 1,
                            Saldo = 2000m,
                            Soort = "S"
                        },
                        new
                        {
                            RekeningNr = "345-6789012-12",
                            KlantNr = 2,
                            Saldo = 500m,
                            Soort = "S"
                        });
                });

            modelBuilder.Entity("Model.Entities.Rekening", b =>
                {
                    b.HasOne("Model.Entities.Klant", "Klant")
                        .WithMany("Rekeningen")
                        .HasForeignKey("KlantNr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klant");
                });

            modelBuilder.Entity("Model.Entities.Klant", b =>
                {
                    b.Navigation("Rekeningen");
                });
#pragma warning restore 612, 618
        }
    }
}
