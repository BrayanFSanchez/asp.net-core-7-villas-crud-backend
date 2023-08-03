﻿// <auto-generated />
using System;
using CrudVillasAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudVillasAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230802233107_AgregarNumeroVillaTabla")]
    partial class AgregarNumeroVillaTabla
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CrudVillasAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupants")
                        .HasColumnType("int");

                    b.Property<int>("SquareMeter")
                        .HasColumnType("int");

                    b.Property<DateTime>("creationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            Detail = "Detalle de la Villa",
                            Fee = 200.0,
                            ImageUrl = "",
                            Name = "Villa Real",
                            Occupants = 5,
                            SquareMeter = 50,
                            creationDate = new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9227),
                            updateDate = new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9242)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            Detail = "Detalle de la Villa",
                            Fee = 150.0,
                            ImageUrl = "",
                            Name = "Villa elegante",
                            Occupants = 4,
                            SquareMeter = 40,
                            creationDate = new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9244),
                            updateDate = new DateTime(2023, 8, 2, 17, 31, 7, 273, DateTimeKind.Local).AddTicks(9244)
                        });
                });

            modelBuilder.Entity("CrudVillasAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("CrudVillasAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("CrudVillasAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}