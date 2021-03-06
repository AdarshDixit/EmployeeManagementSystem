﻿// <auto-generated />
using EmployeeManagementSystem.EMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagementSystem.Migrations
{
    [DbContext(typeof(EmployeeDataContext))]
    [Migration("20200609053957_Seeding Employee data")]
    partial class SeedingEmployeedata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagementSystem.EMS.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = 2,
                            FirstName = "Bruce",
                            LastName = "Lee"
                        },
                        new
                        {
                            Id = 2,
                            Department = 0,
                            FirstName = "Albert",
                            LastName = "Einstein"
                        },
                        new
                        {
                            Id = 3,
                            Department = 1,
                            FirstName = "Mark",
                            LastName = "Zuck"
                        },
                        new
                        {
                            Id = 4,
                            Department = 2,
                            FirstName = "Dwayne",
                            LastName = "Jhonson"
                        },
                        new
                        {
                            Id = 5,
                            Department = 0,
                            FirstName = "Elon",
                            LastName = "Musk"
                        },
                        new
                        {
                            Id = 6,
                            Department = 2,
                            FirstName = "Jackie",
                            LastName = "Chan"
                        },
                        new
                        {
                            Id = 7,
                            Department = 2,
                            FirstName = "Holy",
                            LastName = "Crap"
                        },
                        new
                        {
                            Id = 8,
                            Department = 1,
                            FirstName = "Donald",
                            LastName = "Trump"
                        },
                        new
                        {
                            Id = 9,
                            Department = 2,
                            FirstName = "Crazy",
                            LastName = "Head"
                        },
                        new
                        {
                            Id = 10,
                            Department = 2,
                            FirstName = "Lazy",
                            LastName = "Pant"
                        },
                        new
                        {
                            Id = 11,
                            Department = 2,
                            FirstName = "FName",
                            LastName = "LName"
                        },
                        new
                        {
                            Id = 12,
                            Department = 2,
                            FirstName = "Billi",
                            LastName = "Mandy"
                        },
                        new
                        {
                            Id = 13,
                            Department = 2,
                            FirstName = "Jeff",
                            LastName = "Bezos"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
