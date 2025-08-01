﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupermarketManagmentSystem_SMS.Data;

#nullable disable

namespace SupermarketManagmentSystem_SMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartID");

                    b.HasIndex("UserID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CartID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Description = "",
                            Name = "Fruits"
                        },
                        new
                        {
                            CategoryID = 2,
                            Description = "",
                            Name = "Vegetables"
                        });
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Barcode = "111",
                            CategoryID = 1,
                            Name = "Apple",
                            Price = 1.2m,
                            Quantity = 50
                        },
                        new
                        {
                            ProductID = 2,
                            Barcode = "222",
                            CategoryID = 1,
                            Name = "Banana",
                            Price = 0.8m,
                            Quantity = 20
                        },
                        new
                        {
                            ProductID = 3,
                            Barcode = "333",
                            CategoryID = 2,
                            Name = "Carrot",
                            Price = 0.5m,
                            Quantity = 15
                        },
                        new
                        {
                            ProductID = 4,
                            Barcode = "444",
                            CategoryID = 2,
                            Name = "Broccoli",
                            Price = 1.0m,
                            Quantity = 12
                        });
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Sale", b =>
                {
                    b.Property<int>("SaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CashierID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleID");

                    b.HasIndex("CashierID");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.SaleItem", b =>
                {
                    b.Property<int>("SaleItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaleId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleItemID");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleItems");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("NationalID")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FirstName = "Abdo",
                            LastName = "Mustafa",
                            NationalID = "12345678901234",
                            PasswordHash = "$2a$11$Qfbm.xMkxnC/P5eXUNhNbu8B8xLpMcoCUvPo4lmUL0UPEZbDtEOlK",
                            Role = 0
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "Ahmed",
                            LastName = "Ali",
                            NationalID = "23456789012345",
                            PasswordHash = "$2a$11$3M0QAhnahTkUAaeSq/mWRuj98W2J4FFIa7FwCvOZwsa3GSYbJGrJK",
                            Role = 1
                        });
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Cart", b =>
                {
                    b.HasOne("SupermarketManagmentSystem_SMS.Models.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.CartItem", b =>
                {
                    b.HasOne("SupermarketManagmentSystem_SMS.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SupermarketManagmentSystem_SMS.Models.Product", "Product")
                        .WithMany("CartItems")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Product", b =>
                {
                    b.HasOne("SupermarketManagmentSystem_SMS.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Sale", b =>
                {
                    b.HasOne("SupermarketManagmentSystem_SMS.Models.User", "Cashier")
                        .WithMany("Sales")
                        .HasForeignKey("CashierID");

                    b.Navigation("Cashier");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.SaleItem", b =>
                {
                    b.HasOne("SupermarketManagmentSystem_SMS.Models.Product", "Product")
                        .WithMany("SaleDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SupermarketManagmentSystem_SMS.Models.Sale", "Sale")
                        .WithMany("SaleItem")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Product", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.Sale", b =>
                {
                    b.Navigation("SaleItem");
                });

            modelBuilder.Entity("SupermarketManagmentSystem_SMS.Models.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
