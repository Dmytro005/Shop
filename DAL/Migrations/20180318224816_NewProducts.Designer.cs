﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180318224816_NewProducts")]
    partial class NewProducts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.DomainModels.Catalog", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.HasKey("Id");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.Book", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("CatalogId");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.Gift", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("CatalogId");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("Gift");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.Stationery", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("CatalogId");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("Stationery");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategory.Encyclopedia", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("BookId");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Encyclopedia");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.Casket", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("GiftId");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.ToTable("Casket");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.CopyBook", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("CopyBook");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.DecorativeBox", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("GiftId");

                    b.HasKey("Id");

                    b.HasIndex("GiftId");

                    b.ToTable("DecorativeBox");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.Dictionary", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("Dictionary");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.NoteBook", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("NoteBook");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.OfficeFolder", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("OfficeFolder");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.OfficeSupplies", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("OfficeSupplies");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.SchoolFolder", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("SchoolFolder");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.SchoolSupplies", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("SchoolSupplies");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.Sticker", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("Sticker");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.WritingSupplies", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("WritingSupplies");
                });

            modelBuilder.Entity("Core.Models.DomainModels.ZNO", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<string>("StationeryId");

                    b.HasKey("Id");

                    b.HasIndex("StationeryId");

                    b.ToTable("ZNO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("Role");

                    b.HasDiscriminator().HasValue("Role");
                });

            modelBuilder.Entity("Core.Models.DomainModels.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.ToTable("User");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.Book", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Catalog", "Catalog")
                        .WithMany("Books")
                        .HasForeignKey("CatalogId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.Gift", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Catalog", "Catalog")
                        .WithMany("Gifts")
                        .HasForeignKey("CatalogId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.Stationery", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Catalog", "Catalog")
                        .WithMany("Stationeries")
                        .HasForeignKey("CatalogId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategory.Encyclopedia", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Book", "Book")
                        .WithMany("Encyclopedias")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.Casket", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Gift", "Gift")
                        .WithMany("Caskets")
                        .HasForeignKey("GiftId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.CopyBook", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("CopyBooks")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.DecorativeBox", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Gift", "Gift")
                        .WithMany("DecorativeProducts")
                        .HasForeignKey("GiftId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.Dictionary", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("Dictionaries")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.NoteBook", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("NoteBooks")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.OfficeFolder", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("OfficeFolders")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.OfficeSupplies", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("OfficeSupplies")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.SchoolFolder", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("Categories")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.SchoolSupplies", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("SchoolSupplies")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.Sticker", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("Stickers")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.Category.SubCategoty.WritingSupplies", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("WritingSupplies")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Core.Models.DomainModels.ZNO", b =>
                {
                    b.HasOne("Core.Models.DomainModels.Category.Stationery", "Stationery")
                        .WithMany("ZNOs")
                        .HasForeignKey("StationeryId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
