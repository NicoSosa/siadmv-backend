﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiadMV.DataAccess.Contexts;

namespace SiadMV.DataAccess.Migrations.IdentityDb
{
    [DbContext(typeof(IdentityDbContext))]
    partial class IdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SiadMV.DataAccess.Models.IdentityDb.UserAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address1")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Address2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("AddressType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("UserIdentityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Zipcode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserIdentityId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.IdentityDb.UserIdentity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerSquareId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("UserIdentity");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.IdentityDb.UserProvider", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<Guid>("UserIdentityId")
                        .HasColumnType("char(36)");

                    b.Property<int>("UserProviderValue")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserIdentityId");

                    b.ToTable("UserProvider");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.IdentityDb.UserAddress", b =>
                {
                    b.HasOne("SiadMV.DataAccess.Models.IdentityDb.UserIdentity", "UserIdentity")
                        .WithMany("Addresses")
                        .HasForeignKey("UserIdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.IdentityDb.UserProvider", b =>
                {
                    b.HasOne("SiadMV.DataAccess.Models.IdentityDb.UserIdentity", "UserIdentity")
                        .WithMany("Providers")
                        .HasForeignKey("UserIdentityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
