﻿// <auto-generated />
using CretaceousPark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CretaceousPark.Solution.Migrations
{
    [DbContext(typeof(CretaceousParkContext))]
    [Migration("20220328182809_AddSeedData")]
    partial class AddSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CretaceousPark.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 7,
                            Name = "Matilda",
                            Sex = "Female",
                            Species = "Wooly Mammoth"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Name = "Rexie",
                            Sex = "Female",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 2,
                            Name = "Matilda",
                            Sex = "Female",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Name = "Pip",
                            Sex = "Male",
                            Species = "Shark"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 22,
                            Name = "Bartholomew",
                            Sex = "Male",
                            Species = "Dinosaur"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
