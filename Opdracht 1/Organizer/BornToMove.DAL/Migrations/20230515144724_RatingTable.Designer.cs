﻿// <auto-generated />
using System;
using BornToMove.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BornToMove.DAL.Migrations
{
    [DbContext(typeof(MoveContext))]
    [Migration("20230515144724_RatingTable")]
    partial class RatingTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BornToMove.Move", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SweatRate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("move");
                });

            modelBuilder.Entity("BornToMove.MoveRating", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MoveId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.Property<double>("Vote")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MoveId");

                    b.ToTable("MoveRating");
                });

            modelBuilder.Entity("BornToMove.MoveRating", b =>
                {
                    b.HasOne("BornToMove.Move", "Move")
                        .WithMany("Rating")
                        .HasForeignKey("MoveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Move");
                });

            modelBuilder.Entity("BornToMove.Move", b =>
                {
                    b.Navigation("Rating");
                });
#pragma warning restore 612, 618
        }
    }
}
