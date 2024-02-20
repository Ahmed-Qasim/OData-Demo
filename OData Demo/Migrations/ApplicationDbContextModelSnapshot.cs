﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OData_Demo.Data;

#nullable disable

namespace OData_Demo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OData_Demo.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "234",
                            HiringDate = new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(12),
                            JobCode = "5712",
                            Name = "Ahmed Kassem",
                            SalaryStatus = "valid"
                        },
                        new
                        {
                            Id = 2,
                            Code = "235",
                            HiringDate = new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(66),
                            JobCode = "5712",
                            Name = "Mohamed Kassem",
                            SalaryStatus = "valid"
                        },
                        new
                        {
                            Id = 3,
                            Code = "236",
                            HiringDate = new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(69),
                            JobCode = "5896",
                            Name = "Mazen Ali",
                            SalaryStatus = "valid"
                        },
                        new
                        {
                            Id = 4,
                            Code = "237",
                            HiringDate = new DateTime(2024, 2, 19, 19, 36, 7, 759, DateTimeKind.Local).AddTicks(71),
                            JobCode = "5476",
                            Name = "Taha Emad",
                            SalaryStatus = "unvalid"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
