﻿// <auto-generated />
using Boardgames.ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Boardgames.ConsoleApp.Migrations
{
    [DbContext(typeof(BoardgameContext))]
    [Migration("20200407200218_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Boardgames.ConsoleApp.Models.Boardgame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GameDesignerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlayTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("GameDesignerId");

                    b.ToTable("Boardgames");
                });

            modelBuilder.Entity("Boardgames.ConsoleApp.Models.Gamedesigner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gamedesigners");
                });

            modelBuilder.Entity("Boardgames.ConsoleApp.Models.Boardgame", b =>
                {
                    b.HasOne("Boardgames.ConsoleApp.Models.Gamedesigner", "GameDesigner")
                        .WithMany("Boardgames")
                        .HasForeignKey("GameDesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
