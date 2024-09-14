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
    [Migration("20240914072547_create student entity")]
    partial class createstudententity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
#pragma warning restore 612, 618
        }
    }
}
