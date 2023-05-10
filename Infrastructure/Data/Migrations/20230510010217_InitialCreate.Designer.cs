﻿// <auto-generated />
using API.Data;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20230510010217_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("API.Entity.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("alias")
                        .HasColumnType("TEXT");

                    b.Property<string>("character")
                        .HasColumnType("TEXT");

                    b.Property<string>("coldtolerance")
                        .HasColumnType("TEXT");

                    b.Property<string>("detail")
                        .HasColumnType("TEXT");

                    b.Property<string>("friendliness")
                        .HasColumnType("TEXT");

                    b.Property<string>("heatresistance")
                        .HasColumnType("TEXT");

                    b.Property<string>("size")
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pet");
                });
#pragma warning restore 612, 618
        }
    }
}
