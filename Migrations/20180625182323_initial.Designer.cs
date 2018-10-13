﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QualificationWork.Models;

namespace QualificationWork.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20180625182323_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QualificationWork.Models.Branche", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Director");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("QualificationWork.Models.Nomenclature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<Guid>("CreateUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("Date");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Price");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<Guid>("UpdateUserId");

                    b.HasKey("Id");

                    b.ToTable("Nomenclatures");
                });
#pragma warning restore 612, 618
        }
    }
}
