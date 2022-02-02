﻿// <auto-generated />
using HospitalsMVC2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalsMVC2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220202052115_SeedHospitalsInitTestData")]
    partial class SeedHospitalsInitTestData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalsMVC2.Models.Hospital", b =>
                {
                    b.Property<int>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HospitalId");

                    b.ToTable("Hospitals");

                    b.HasData(
                        new
                        {
                            HospitalId = 1,
                            Address = "Dallas, TX",
                            Email = "UTSMC@test.com",
                            Name = "UT Southwestern Medical Center",
                            Phone = "(123) 123-4567"
                        },
                        new
                        {
                            HospitalId = 2,
                            Address = "Dallas, TX",
                            Email = "BUMC@test.com",
                            Name = "Baylor University Medical Center",
                            Phone = "(111) 111-1111"
                        },
                        new
                        {
                            HospitalId = 3,
                            Address = "Dallas, TX",
                            Email = "MCD@test.com",
                            Name = "Medical City Dallas",
                            Phone = "(222) 222-2222"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
