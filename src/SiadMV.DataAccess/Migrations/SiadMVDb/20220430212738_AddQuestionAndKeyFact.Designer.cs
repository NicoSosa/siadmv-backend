﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiadMV.DataAccess.Contexts;

namespace SiadMV.DataAccess.Migrations.SiadMVDb
{
    [DbContext(typeof(SiadMVDbContext))]
    [Migration("20220430212738_AddQuestionAndKeyFact")]
    partial class AddQuestionAndKeyFact
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SiadMV.DataAccess.Models.SiadMVDb.KeyFact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("KeyFact");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.SiadMVDb.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.SiadMVDb.QuestionKeyFact", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("KeyFactId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id")
                        .HasColumnType("char(36)");

                    b.HasKey("QuestionId", "KeyFactId");

                    b.HasIndex("KeyFactId");

                    b.ToTable("QuestionKeyFact");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.SiadMVDb.UserCase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("LastUpdateDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("UserCase");
                });

            modelBuilder.Entity("SiadMV.DataAccess.Models.SiadMVDb.QuestionKeyFact", b =>
                {
                    b.HasOne("SiadMV.DataAccess.Models.SiadMVDb.KeyFact", "KeyFact")
                        .WithMany("Questions")
                        .HasForeignKey("KeyFactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SiadMV.DataAccess.Models.SiadMVDb.Question", "Question")
                        .WithMany("KeysFact")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
