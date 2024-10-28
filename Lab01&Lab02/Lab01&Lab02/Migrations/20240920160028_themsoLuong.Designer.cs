﻿// <auto-generated />
using System;
using Lab01_Lab02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab01Lab02.Migrations
{
    [DbContext(typeof(MyDataDbContext))]
    [Migration("20240920160028_themsoLuong")]
    partial class themsoLuong
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab01_Lab02.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"),
                            Date = new DateTime(2024, 9, 20, 23, 0, 28, 28, DateTimeKind.Local).AddTicks(7918),
                            Location = "Ha noi",
                            Name = "Nhung thanh pho mi mang"
                        });
                });

            modelBuilder.Entity("Lab01_Lab02.Models.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDEvent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IDEvent");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c0e2476e-89b7-48b1-85de-6b4e3ee2887e"),
                            IDEvent = new Guid("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"),
                            Price = 200000m,
                            SeatNumber = "S16",
                            soLuong = 0
                        });
                });

            modelBuilder.Entity("Lab01_Lab02.Models.Ticket", b =>
                {
                    b.HasOne("Lab01_Lab02.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("IDEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Lab01_Lab02.Models.Event", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}