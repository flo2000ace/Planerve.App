﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planerve.App.Persistence;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    [DbContext(typeof(PlanerveDbContext))]
    [Migration("20220226154521_tester6")]
    partial class tester6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<string>("FullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SiteApiData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Codes", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("admin_county")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_ward")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ccg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ccg_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ced")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lau2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lsoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("msoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nuts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("parliamentary_constituency")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Codes");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Result", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("admin_county")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_district")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("admin_ward")
                        .HasColumnType("nvarchar(max)");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primary_care_trust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quality")
                        .HasColumnType("int");

                    b.Property<string>("region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.ApplicationTypeOne", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OneTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationTypeOne");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.ApplicationTypeTwo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OneTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationTypeTwo");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "Application")
                        .WithOne("SiteApiData")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Codes", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Result", "Result")
                        .WithOne("codes")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Codes", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Result");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Result", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData", "SiteApiData")
                        .WithOne("result")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Result", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiteApiData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.ApplicationTypeOne", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "Application")
                        .WithOne("ApplicationTypeOne")
                        .HasForeignKey("Planerve.App.Domain.Entities.FormEntities.ApplicationTypeOne", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.ApplicationTypeTwo", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "Application")
                        .WithOne("ApplicationTypeTwo")
                        .HasForeignKey("Planerve.App.Domain.Entities.FormEntities.ApplicationTypeTwo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Application", b =>
                {
                    b.Navigation("ApplicationTypeOne");

                    b.Navigation("ApplicationTypeTwo");

                    b.Navigation("SiteApiData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData", b =>
                {
                    b.Navigation("result");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.SiteApiData+Result", b =>
                {
                    b.Navigation("codes");
                });
#pragma warning restore 612, 618
        }
    }
}
