﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RAPI.Data;

namespace RAPI.Migrations
{
    [DbContext(typeof(RAPIContext))]
    partial class RAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("RAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("RAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("StorageAmount")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Unit")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("RAPI.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Zip")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("RAPI.Models.Product", b =>
                {
                    b.HasOne("RAPI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("RAPI.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
