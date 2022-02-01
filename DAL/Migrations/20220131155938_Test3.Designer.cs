﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20220131155938_Test3")]
    partial class Test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Campaigns", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PriceReduction")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("DAL.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"), 1L, 1);

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DAL.Email", b =>
                {
                    b.Property<string>("Emails")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("Emails", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<int>("EndDate")
                        .HasColumnType("int");

                    b.Property<int>("Mentor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNr")
                        .HasColumnType("int");

                    b.Property<int>("SSN")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DAL.Ingredients", b =>
                {
                    b.Property<string>("Ingredient")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.HasKey("Ingredient", "Product");

                    b.HasIndex("ProductsID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("DAL.Products", b =>
                {
                    b.Property<int>("ProductsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsID"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Barcode")
                        .HasColumnType("int");

                    b.Property<int>("CampaignsID")
                        .HasColumnType("int");

                    b.Property<int>("ExpirationDate")
                        .HasColumnType("int");

                    b.Property<int>("InventoryBy")
                        .HasColumnType("int");

                    b.Property<int>("InventoryDate")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductsID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DepartmentProducts", b =>
                {
                    b.Property<int>("DepartmentsDepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsDepartmentID", "ProductsID");

                    b.HasIndex("ProductsID");

                    b.ToTable("DepartmentProducts");
                });

            modelBuilder.Entity("DAL.Email", b =>
                {
                    b.HasOne("DAL.Employee", "Employee")
                        .WithMany("Emails")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DAL.Ingredients", b =>
                {
                    b.HasOne("DAL.Products", "products")
                        .WithMany("Ingredients")
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");
                });

            modelBuilder.Entity("DepartmentProducts", b =>
                {
                    b.HasOne("DAL.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Products", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Employee", b =>
                {
                    b.Navigation("Emails");
                });

            modelBuilder.Entity("DAL.Products", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
