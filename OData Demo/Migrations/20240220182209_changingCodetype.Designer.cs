﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OData_Demo.Data;

#nullable disable

namespace OData_Demo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240220182209_changingCodetype")]
    partial class changingCodetype
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Code")
                        .HasColumnType("int");

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
                            Code = 234,
                            HiringDate = new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(6974),
                            JobCode = "5712",
                            Name = "Ahmed Kassem",
                            SalaryStatus = "valid"
                        },
                        new
                        {
                            Id = 2,
                            Code = 235,
                            HiringDate = new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(7037),
                            JobCode = "5712",
                            Name = "Mohamed Kassem",
                            SalaryStatus = "valid"
                        },
                        new
                        {
                            Id = 3,
                            Code = 236,
                            HiringDate = new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(7040),
                            JobCode = "5896",
                            Name = "Mazen Ali",
                            SalaryStatus = "valid"
                        },
                        new
                        {
                            Id = 4,
                            Code = 237,
                            HiringDate = new DateTime(2024, 2, 20, 20, 22, 8, 87, DateTimeKind.Local).AddTicks(7043),
                            JobCode = "5476",
                            Name = "Taha Emad",
                            SalaryStatus = "unvalid"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}