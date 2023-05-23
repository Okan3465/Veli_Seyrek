﻿// <auto-generated />
using System;
using API_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Project.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230403072504_Updated_Mig")]
    partial class Updated_Mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_Project.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 3, 31, 10, 25, 4, 449, DateTimeKind.Local).AddTicks(5099),
                            Name = "Bilgisayar",
                            Price = 10000m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 3, 4, 10, 25, 4, 450, DateTimeKind.Local).AddTicks(3064),
                            Name = "Telefon",
                            Price = 15000m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 2, 2, 10, 25, 4, 450, DateTimeKind.Local).AddTicks(3082),
                            Name = "Klavye",
                            Price = 150m,
                            Stock = 300
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
