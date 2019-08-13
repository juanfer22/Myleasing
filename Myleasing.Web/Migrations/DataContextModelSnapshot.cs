﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Myleasing.Web.Date;

namespace Myleasing.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Myleasing.Web.Data.Entities.Lessee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("CellPhone")
                        .HasMaxLength(20);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FixedPhone")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Lessees");
                });

            modelBuilder.Entity("Myleasing.Web.Data.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("HasParkingLot");

                    b.Property<bool>("IsAvailable");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("OwnerId");

                    b.Property<decimal>("Price");

                    b.Property<int?>("PropertyTypeId");

                    b.Property<string>("Remarks");

                    b.Property<int>("Rooms");

                    b.Property<int>("SquareMeters");

                    b.Property<int>("Stratum");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("Myleasing.Web.Data.Entities.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("Myleasing.Web.Date.Entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("LesseeId");

                    b.Property<int?>("OwnerId");

                    b.Property<decimal>("Price");

                    b.Property<int?>("PropertyId");

                    b.Property<string>("Remarks")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("LesseeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Myleasing.Web.Date.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(20);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FixedPhone")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Myleasing.Web.Date.Entities.PropertyImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .IsRequired();

                    b.Property<int?>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyImages");
                });

            modelBuilder.Entity("Myleasing.Web.Data.Entities.Property", b =>
                {
                    b.HasOne("Myleasing.Web.Date.Entities.Owner", "Owner")
                        .WithMany("Properties")
                        .HasForeignKey("OwnerId");

                    b.HasOne("Myleasing.Web.Data.Entities.PropertyType", "PropertyType")
                        .WithMany("Properties")
                        .HasForeignKey("PropertyTypeId");
                });

            modelBuilder.Entity("Myleasing.Web.Date.Entities.Contract", b =>
                {
                    b.HasOne("Myleasing.Web.Data.Entities.Lessee", "Lessee")
                        .WithMany("Contracts")
                        .HasForeignKey("LesseeId");

                    b.HasOne("Myleasing.Web.Date.Entities.Owner", "Owner")
                        .WithMany("Contracts")
                        .HasForeignKey("OwnerId");

                    b.HasOne("Myleasing.Web.Data.Entities.Property", "Property")
                        .WithMany("Contracts")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("Myleasing.Web.Date.Entities.PropertyImage", b =>
                {
                    b.HasOne("Myleasing.Web.Data.Entities.Property", "Property")
                        .WithMany("PropertyImages")
                        .HasForeignKey("PropertyId");
                });
#pragma warning restore 612, 618
        }
    }
}
