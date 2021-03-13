﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tttest.DbContexts;

namespace tttest.Migrations
{
    [DbContext(typeof(Dbcon))]
    [Migration("20210313061134_sss")]
    partial class sss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tttest.Models.Empolyee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateofb")
                        .HasColumnType("datetime2");

                    b.Property<string>("department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("empolyees");
                });
#pragma warning restore 612, 618
        }
    }
}
