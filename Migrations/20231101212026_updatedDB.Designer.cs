﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pet_hotel.Models;

#nullable disable

namespace pet_hotel_7._0.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231101212026_updatedDB")]
    partial class updatedDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pet_hotel.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CheckedInAt")
                        .IsRequired()
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnedById")
                        .HasColumnType("integer");

                    b.Property<int>("PetBreed")
                        .HasColumnType("integer");

                    b.Property<int>("PetColor")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnedById");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("pet_hotel.Models.PetOwner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PetOwners");
                });

            modelBuilder.Entity("pet_hotel.Models.Pet", b =>
                {
                    b.HasOne("pet_hotel.Models.PetOwner", "OwnedBy")
                        .WithMany()
                        .HasForeignKey("OwnedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OwnedBy");
                });
#pragma warning restore 612, 618
        }
    }
}
