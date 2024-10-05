﻿// <auto-generated />
using FirstMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstMVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241005070202_add-emploee-person-entity")]
    partial class addemploeepersonentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstMVC.Models.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FirstMVC.Models.Entities.Student", b =>
                {
                    b.Property<long>("MaSinhVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MaSinhVien"));

                    b.Property<string>("TenSinhVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSinhVien");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("FirstMVC.Models.Entities.Employee", b =>
                {
                    b.HasBaseType("FirstMVC.Models.Entities.Person");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
