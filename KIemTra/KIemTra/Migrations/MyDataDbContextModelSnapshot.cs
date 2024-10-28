﻿// <auto-generated />
using System;
using KIemTra.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KIemTra.Migrations
{
    [DbContext(typeof(MyDataDbContext))]
    partial class MyDataDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KIemTra.Model.DonHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSach")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("KhachHangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KhachHangId");

                    b.ToTable("DonHang");
                });

            modelBuilder.Entity("KIemTra.Model.HoaDonSach", b =>
                {
                    b.Property<Guid>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SachId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HoaDonId", "SachId");

                    b.HasIndex("SachId");

                    b.ToTable("HoaDonSach");
                });

            modelBuilder.Entity("KIemTra.Model.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("KIemTra.Model.Sach", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TacGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("KIemTra.Model.DonHang", b =>
                {
                    b.HasOne("KIemTra.Model.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("KhachHangId");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("KIemTra.Model.HoaDonSach", b =>
                {
                    b.HasOne("KIemTra.Model.DonHang", "HoaDon")
                        .WithMany("HoaDonSachs")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KIemTra.Model.Sach", "Sach")
                        .WithMany("HoaDonSachs")
                        .HasForeignKey("SachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("KIemTra.Model.DonHang", b =>
                {
                    b.Navigation("HoaDonSachs");
                });

            modelBuilder.Entity("KIemTra.Model.Sach", b =>
                {
                    b.Navigation("HoaDonSachs");
                });
#pragma warning restore 612, 618
        }
    }
}
