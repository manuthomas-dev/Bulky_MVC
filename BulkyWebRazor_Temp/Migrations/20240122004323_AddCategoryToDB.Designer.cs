﻿// <auto-generated />
using BulkyWebRazor_Temp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyWebRazor_Temp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20240122004323_AddCategoryToDB")]
    partial class AddCategoryToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkyWebRazor_Temp.Models.Category", b =>
                {
                    b.Property<int>("intCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("intCategoryId"));

                    b.Property<int>("intDisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("strCategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("intCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            intCategoryId = 1,
                            intDisplayOrder = 1,
                            strCategoryName = "Anime"
                        },
                        new
                        {
                            intCategoryId = 2,
                            intDisplayOrder = 2,
                            strCategoryName = "Action"
                        },
                        new
                        {
                            intCategoryId = 3,
                            intDisplayOrder = 3,
                            strCategoryName = "Adventure"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
