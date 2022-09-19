﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace CardGameApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220919130755_DatabaseCreationWODeck1")]
    partial class DatabaseCreationWODeck1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entites.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Suit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImgUrl = "/images/hearts.jpg",
                            IsActive = true,
                            Number = 50,
                            Suit = 0
                        });
                });

            modelBuilder.Entity("Entites.Models.HandHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CardIdFive")
                        .HasColumnType("int");

                    b.Property<int>("CardIdFour")
                        .HasColumnType("int");

                    b.Property<int>("CardIdOne")
                        .HasColumnType("int");

                    b.Property<int>("CardIdThree")
                        .HasColumnType("int");

                    b.Property<int>("CardIdTwo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HandHistories");
                });
#pragma warning restore 612, 618
        }
    }
}