﻿// <auto-generated />
using GroceryStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605164826_InsertProducts2")]
    partial class InsertProducts2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("GroceryStore.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            Address = "Riyadh",
                            Name = "Norah Grocery"
                        },
                        new
                        {
                            BranchId = 2,
                            Address = "Dammam",
                            Name = "Norah Grocery"
                        },
                        new
                        {
                            BranchId = 3,
                            Address = "Jeddah",
                            Name = "Norah Grocery"
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.BranchProduct", b =>
                {
                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("BranchId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("BranchProduct");
                });

            modelBuilder.Entity("GroceryStore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Jeddah, Al Marwah, Saeed Albasri street",
                            Email = "norah@outlook.sa",
                            FirstName = "Norah",
                            LastName = "Almutairi",
                            Phone = "0534355512"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Riyadh, Al Narjis, Alsalamah street",
                            Email = "Maha@outlook.sa",
                            FirstName = "Maha",
                            LastName = "Alzahrani",
                            Phone = "0565355519"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Dammam, Al Rawdah, Malik Ibn Jubair street",
                            Email = "Mona@outlook.sa",
                            FirstName = "Mona",
                            LastName = "Alghamdi",
                            Phone = "0535366514"
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.CustomerProduct", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProduct");
                });

            modelBuilder.Entity("GroceryStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Name = "Apple",
                            Price = 1.5f
                        },
                        new
                        {
                            ProductId = 2,
                            Name = "Orange",
                            Price = 2.5f
                        },
                        new
                        {
                            ProductId = 3,
                            Name = "Banana",
                            Price = 3.5f
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GroceryStore.Models.BranchProduct", b =>
                {
                    b.HasOne("GroceryStore.Models.Branch", "Branch")
                        .WithMany("BranchProduct")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Models.Product", "Product")
                        .WithMany("BranchProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GroceryStore.Models.CustomerProduct", b =>
                {
                    b.HasOne("GroceryStore.Models.Customer", "Customer")
                        .WithMany("CustomerProduct")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Models.Product", "Product")
                        .WithMany("CustomerProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GroceryStore.Models.User", b =>
                {
                    b.HasOne("GroceryStore.Models.Customer", "Customer")
                        .WithOne("User")
                        .HasForeignKey("GroceryStore.Models.User", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GroceryStore.Models.Branch", b =>
                {
                    b.Navigation("BranchProduct");
                });

            modelBuilder.Entity("GroceryStore.Models.Customer", b =>
                {
                    b.Navigation("CustomerProduct");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GroceryStore.Models.Product", b =>
                {
                    b.Navigation("BranchProduct");

                    b.Navigation("CustomerProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
