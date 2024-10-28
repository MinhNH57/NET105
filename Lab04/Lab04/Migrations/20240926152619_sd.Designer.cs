﻿// <auto-generated />
using System;
using Lab03_04.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab04.Migrations
{
    [DbContext(typeof(SinhVienDbContext))]
    [Migration("20240926152619_sd")]
    partial class sd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab03_04.Models.LopHocModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LopHoc");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e581809-e2a0-4848-a30a-a9d9d7f2f72a"),
                            Name = "SD18406"
                        });
                });

            modelBuilder.Entity("Lab03_04.Models.SinhVienModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("SinhVien");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d7ad6cd-2e1d-4ec8-9b31-8e6c8a88c635"),
                            Age = 20,
                            ClassId = new Guid("3e581809-e2a0-4848-a30a-a9d9d7f2f72a"),
                            Major = "CNTT",
                            Name = "Nguyen Hong Minh"
                        });
                });

            modelBuilder.Entity("Lab03_04.Models.SinhVienModel", b =>
                {
                    b.HasOne("Lab03_04.Models.LopHocModel", "LopHoc")
                        .WithMany("SinhViens")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LopHoc");
                });

            modelBuilder.Entity("Lab03_04.Models.LopHocModel", b =>
                {
                    b.Navigation("SinhViens");
                });
#pragma warning restore 612, 618
        }
    }
}
