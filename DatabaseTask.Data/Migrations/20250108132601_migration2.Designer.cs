﻿// <auto-generated />
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    [Migration("20250108132601_migration2")]
    partial class migration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.ProjectEmployee", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("ProjectID");

                    b.ToTable("ProjectEmployee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.ProjectSpecialist", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"), 1L, 1);

                    b.Property<int>("SpecialistID")
                        .HasColumnType("int");

                    b.HasKey("ProjectID");

                    b.ToTable("ProjectSpecialist");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Specialist", b =>
                {
                    b.Property<int>("SpecialistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialistID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialistID");

                    b.ToTable("Specialist");
                });
#pragma warning restore 612, 618
        }
    }
}
