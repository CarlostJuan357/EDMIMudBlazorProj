﻿// <auto-generated />
using System;
using EDMIMudblazorProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EDMIMudblazorProject.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("EDMIMudblazorProject.Data.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Salary")
                        .HasColumnType("REAL");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1001,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "Andrew",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4081),
                            JobTitle = "Senior Dev",
                            LastName = "Tate",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        },
                        new
                        {
                            EmployeeId = 1002,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "Tiger",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4097),
                            JobTitle = "Senior Dev",
                            LastName = "Woods",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        },
                        new
                        {
                            EmployeeId = 1003,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "Prince",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4098),
                            JobTitle = "Senior Dev",
                            LastName = "Charles",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        },
                        new
                        {
                            EmployeeId = 1004,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "John",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4100),
                            JobTitle = "Senior Dev",
                            LastName = "Wick",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        },
                        new
                        {
                            EmployeeId = 1005,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "Nice",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4101),
                            JobTitle = "Senior Dev",
                            LastName = "Guy",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        },
                        new
                        {
                            EmployeeId = 1006,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "Nate",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4104),
                            JobTitle = "Senior Dev",
                            LastName = "Diaz",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        },
                        new
                        {
                            EmployeeId = 1007,
                            DepartmentName = "Internal",
                            Email = "testEmail@gmail.com",
                            FirstName = "Lionel",
                            HireDate = new DateTime(2023, 5, 15, 3, 54, 50, 179, DateTimeKind.Local).AddTicks(4105),
                            JobTitle = "Senior Dev",
                            LastName = "Messi",
                            PhoneNumber = "+639521087463",
                            Salary = 60000.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
