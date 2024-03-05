﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using stok_takip_1.Data;

#nullable disable

namespace stok_takip_1.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20240305111227_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("stok_takip_1.Entities.Categories", b =>
                {
                    b.Property<int>("Category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Category_id"));

                    b.Property<string>("Category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Category_id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("stok_takip_1.Entities.OrderDetails", b =>
                {
                    b.Property<int>("Order_detail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_detail_id"));

                    b.Property<string>("Order_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order_id")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("kdv")
                        .HasColumnType("int");

                    b.HasKey("Order_detail_id");

                    b.HasIndex("Order_id");

                    b.HasIndex("Product_id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("stok_takip_1.Entities.Orders", b =>
                {
                    b.Property<int>("Order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Order_id"));

                    b.Property<DateTime>("Delivery_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Order_Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Payment_Method")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Supplier_id")
                        .HasColumnType("int");

                    b.HasKey("Order_id");

                    b.HasIndex("Supplier_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("stok_takip_1.Entities.Product_Brands", b =>
                {
                    b.Property<int>("Brand_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Brand_id"));

                    b.Property<string>("Brand_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Brand_id");

                    b.ToTable("Product_Brands");
                });

            modelBuilder.Entity("stok_takip_1.Entities.Products", b =>
                {
                    b.Property<int>("Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_id"));

                    b.Property<int>("Brand_id")
                        .HasColumnType("int");

                    b.Property<int>("Category_id")
                        .HasColumnType("int");

                    b.Property<int>("Minimum_Stock_Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.Property<int>("Product_Brand_id")
                        .HasColumnType("int");

                    b.Property<string>("Product_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Product_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Stock_Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<decimal>("kdv")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("Product_id");

                    b.HasIndex("Brand_id");

                    b.HasIndex("Category_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("stok_takip_1.Entities.Suppliers", b =>
                {
                    b.Property<int>("Supplier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Supplier_id"));

                    b.Property<string>("Supplier_address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Supplier_email")
                        .IsRequired()
                        .HasMaxLength(155)
                        .HasColumnType("nvarchar(155)");

                    b.Property<string>("Supplier_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Supplier_phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Supplier_id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("stok_takip_1.Entities.OrderDetails", b =>
                {
                    b.HasOne("stok_takip_1.Entities.Orders", "Orders")
                        .WithMany()
                        .HasForeignKey("Order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("stok_takip_1.Entities.Products", "Products")
                        .WithMany()
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("stok_takip_1.Entities.Orders", b =>
                {
                    b.HasOne("stok_takip_1.Entities.Suppliers", "Suppliers")
                        .WithMany()
                        .HasForeignKey("Supplier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("stok_takip_1.Entities.Products", b =>
                {
                    b.HasOne("stok_takip_1.Entities.Product_Brands", "Product_Brands")
                        .WithMany()
                        .HasForeignKey("Brand_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("stok_takip_1.Entities.Categories", "Categories")
                        .WithMany()
                        .HasForeignKey("Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Product_Brands");
                });
#pragma warning restore 612, 618
        }
    }
}
