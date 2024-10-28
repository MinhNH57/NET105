﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practice_CRUD.Models;

#nullable disable

namespace PracticeCRUD.Migrations
{
    [DbContext(typeof(MyDataDbcontext))]
    [Migration("20240918162849_dsa")]
    partial class dsa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Practice_CRUD.Models.LopHoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LopHocs");

                    b.HasData(
                        new
                        {
                            ID = new Guid("dc3a2078-02ae-4002-8116-bd168fa48cbf"),
                            NameClass = "SD18406"
                        });
                });

            modelBuilder.Entity("Practice_CRUD.Models.SInhVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDLopHoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IDLopHoc");

                    b.ToTable("SinhViens");

                    b.HasData(
                        new
                        {
                            ID = new Guid("ea6a0dfc-ae8d-41cd-9f43-f04284e3188c"),
                            Address = "Phung Xa",
                            IDLopHoc = new Guid("dc3a2078-02ae-4002-8116-bd168fa48cbf"),
                            Name = "Nguyen Hong Minh"
                        });
                });

            modelBuilder.Entity("Practice_CRUD.Models.SInhVien", b =>
                {
                    b.HasOne("Practice_CRUD.Models.LopHoc", "lophoc")
                        .WithMany("sInhviens")
                        .HasForeignKey("IDLopHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lophoc");
                });

            modelBuilder.Entity("Practice_CRUD.Models.LopHoc", b =>
                {
                    b.Navigation("sInhviens");
                });
#pragma warning restore 612, 618
        }
    }
}
