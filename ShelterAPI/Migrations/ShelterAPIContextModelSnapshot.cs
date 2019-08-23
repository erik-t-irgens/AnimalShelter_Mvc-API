﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShelterAPI.Helpers;

namespace ShelterAPI.Migrations
{
    [DbContext(typeof(ShelterAPIContext))]
    partial class ShelterAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShelterAPI.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Admission");

                    b.Property<int>("Age");

                    b.Property<int?>("BreedId");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.HasIndex("BreedId");

                    b.ToTable("animals");
                });

            modelBuilder.Entity("ShelterAPI.Models.Breed", b =>
                {
                    b.Property<int>("BreedId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("BreedId");

                    b.ToTable("breeds");
                });

            modelBuilder.Entity("ShelterAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ShelterAPI.Models.Animal", b =>
                {
                    b.HasOne("ShelterAPI.Models.Breed", "Breed")
                        .WithMany("Animals")
                        .HasForeignKey("BreedId");
                });
#pragma warning restore 612, 618
        }
    }
}
