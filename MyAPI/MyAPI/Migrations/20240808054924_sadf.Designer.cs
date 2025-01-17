﻿// <auto-generated />
using System;
using Db_Watch_and_Ring.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MyAPI.Migrations
{
    [DbContext(typeof(WatchDbContext))]
    [Migration("20240808054924_sadf")]
    partial class sadf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Db_Watch_and_Ring.Models.ChatLieu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenChatLieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("chatLieus");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DayDeo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoaiDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenClDay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DayDeos");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHo", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LoaiMayID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MatKinhID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamRaDoi")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("thuonghieuID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("LoaiMayID")
                        .IsUnique()
                        .HasFilter("[LoaiMayID] IS NOT NULL");

                    b.HasIndex("MatKinhID")
                        .IsUnique()
                        .HasFilter("[MatKinhID] IS NOT NULL");

                    b.HasIndex("thuonghieuID");

                    b.ToTable("DongHos");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DayDeoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DongHoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NamSX")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SizeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TienIch")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DayDeoID")
                        .IsUnique()
                        .HasFilter("[DayDeoID] IS NOT NULL");

                    b.HasIndex("DongHoID");

                    b.HasIndex("SizeID")
                        .IsUnique()
                        .HasFilter("[SizeID] IS NOT NULL");

                    b.ToTable("DongHoCTs");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT_ChatLieu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("chatlieuID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("donghoctID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("chatlieuID");

                    b.HasIndex("donghoctID");

                    b.ToTable("DongHoCT_ChatLieu");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT_MauSac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("donghoctID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("mausacID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("donghoctID");

                    b.HasIndex("mausacID");

                    b.ToTable("DongHoCT_MauSac");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.LoaiMay", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoaiMay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("LoaiMays");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.MatKinh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenCl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MatKinhs");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.MauSac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenMau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MauSacs");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.Size", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.ThuongHieu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NamThanhLap")
                        .HasColumnType("int");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ThuongHieus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyAPI.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHo", b =>
                {
                    b.HasOne("Db_Watch_and_Ring.Models.LoaiMay", "loaimay")
                        .WithOne("dongho")
                        .HasForeignKey("Db_Watch_and_Ring.Models.DongHo", "LoaiMayID");

                    b.HasOne("Db_Watch_and_Ring.Models.MatKinh", "matkinh")
                        .WithOne("dongho")
                        .HasForeignKey("Db_Watch_and_Ring.Models.DongHo", "MatKinhID");

                    b.HasOne("Db_Watch_and_Ring.Models.ThuongHieu", "thuonghieu")
                        .WithMany("DongHos")
                        .HasForeignKey("thuonghieuID");

                    b.Navigation("loaimay");

                    b.Navigation("matkinh");

                    b.Navigation("thuonghieu");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT", b =>
                {
                    b.HasOne("Db_Watch_and_Ring.Models.DayDeo", "daydeo")
                        .WithOne("donghoct")
                        .HasForeignKey("Db_Watch_and_Ring.Models.DongHoCT", "DayDeoID");

                    b.HasOne("Db_Watch_and_Ring.Models.DongHo", "DongHo")
                        .WithMany("DongHoCTs")
                        .HasForeignKey("DongHoID");

                    b.HasOne("Db_Watch_and_Ring.Models.Size", "size")
                        .WithOne("donghoct")
                        .HasForeignKey("Db_Watch_and_Ring.Models.DongHoCT", "SizeID");

                    b.Navigation("DongHo");

                    b.Navigation("daydeo");

                    b.Navigation("size");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT_ChatLieu", b =>
                {
                    b.HasOne("Db_Watch_and_Ring.Models.ChatLieu", "chatlieu")
                        .WithMany("cl_dhct")
                        .HasForeignKey("chatlieuID");

                    b.HasOne("Db_Watch_and_Ring.Models.DongHoCT", "donghoct")
                        .WithMany("hdct_cl")
                        .HasForeignKey("donghoctID");

                    b.Navigation("chatlieu");

                    b.Navigation("donghoct");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT_MauSac", b =>
                {
                    b.HasOne("Db_Watch_and_Ring.Models.DongHoCT", "donghoct")
                        .WithMany("dhct_ms")
                        .HasForeignKey("donghoctID");

                    b.HasOne("Db_Watch_and_Ring.Models.MauSac", "mausac")
                        .WithMany("ms_dhct")
                        .HasForeignKey("mausacID");

                    b.Navigation("donghoct");

                    b.Navigation("mausac");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyAPI.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.ChatLieu", b =>
                {
                    b.Navigation("cl_dhct");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DayDeo", b =>
                {
                    b.Navigation("donghoct");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHo", b =>
                {
                    b.Navigation("DongHoCTs");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.DongHoCT", b =>
                {
                    b.Navigation("dhct_ms");

                    b.Navigation("hdct_cl");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.LoaiMay", b =>
                {
                    b.Navigation("dongho");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.MatKinh", b =>
                {
                    b.Navigation("dongho")
                        .IsRequired();
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.MauSac", b =>
                {
                    b.Navigation("ms_dhct");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.Size", b =>
                {
                    b.Navigation("donghoct");
                });

            modelBuilder.Entity("Db_Watch_and_Ring.Models.ThuongHieu", b =>
                {
                    b.Navigation("DongHos");
                });
#pragma warning restore 612, 618
        }
    }
}
