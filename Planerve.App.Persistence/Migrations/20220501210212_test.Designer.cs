﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planerve.App.Persistence.Contexts;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    [DbContext(typeof(PlanerveDbContext))]
    [Migration("20220501210212_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressLineOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLineThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLineTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_county")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("administrative_county");

                    b.Property<string>("admin_district")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("administrative_district");

                    b.Property<string>("admin_ward")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("administrative_ward");

                    b.Property<string>("ccg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ced")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("eastings")
                        .HasColumnType("int");

                    b.Property<string>("european_electoral_region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("incode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("latitude")
                        .HasColumnType("real");

                    b.Property<float>("longitude")
                        .HasColumnType("real");

                    b.Property<string>("lsoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("msoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nhs_ha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("northings")
                        .HasColumnType("int");

                    b.Property<string>("nuts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("outcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parliamentary_constituency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primary_care_trust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quality")
                        .HasColumnType("int");

                    b.Property<string>("region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicationType")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.AuthorisedUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CopyApplication")
                        .HasColumnType("bit");

                    b.Property<bool>("DownloadForm")
                        .HasColumnType("bit");

                    b.Property<bool>("EditForm")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<bool>("ReadApplication")
                        .HasColumnType("bit");

                    b.Property<bool>("ReadForm")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("AuthorisedUser");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Checklist", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CalculatedFee")
                        .HasColumnType("bit");

                    b.Property<bool>("FormSections")
                        .HasColumnType("bit");

                    b.Property<bool>("PlansAndDocs")
                        .HasColumnType("bit");

                    b.Property<bool>("SubmittedToLocalAuthority")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Checklist");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeOne", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EastingValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NorthingValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormTypeOne");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeTwo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingSuffix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EastingValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NorthingValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormTypeTwo");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Address", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "ApplicationData")
                        .WithOne("AddressData")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.Address", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.AuthorisedUser", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", null)
                        .WithMany("AuthorisedUsers")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Checklist", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "ApplicationData")
                        .WithOne("ChecklistData")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.Checklist", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Form", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "ApplicationData")
                        .WithOne("FormData")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.Form", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeOne", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Form", "FormData")
                        .WithOne("FormTypeOneData")
                        .HasForeignKey("Planerve.App.Domain.Entities.FormEntities.FormTypeOne", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeTwo", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Form", "FormData")
                        .WithOne("FormTypeTwoData")
                        .HasForeignKey("Planerve.App.Domain.Entities.FormEntities.FormTypeTwo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Application", b =>
                {
                    b.Navigation("AddressData");

                    b.Navigation("AuthorisedUsers");

                    b.Navigation("ChecklistData");

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Form", b =>
                {
                    b.Navigation("FormTypeOneData");

                    b.Navigation("FormTypeTwoData");
                });
#pragma warning restore 612, 618
        }
    }
}