﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using Project.Infrastructure;
using System;

namespace Project.API.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    [Migration("20180508090904_InitProjectDb")]
    partial class InitProjectDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("Project.Domain.AggregatesModel.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaId");

                    b.Property<string>("AreaName");

                    b.Property<string>("Avator");

                    b.Property<int>("BrokerageOptions");

                    b.Property<int>("CityId");

                    b.Property<string>("CityName");

                    b.Property<string>("Company");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("FinMoney");

                    b.Property<string>("FinPercentag");

                    b.Property<string>("FinStage");

                    b.Property<string>("ForamteBPFile");

                    b.Property<int>("Income");

                    b.Property<string>("Introduction");

                    b.Property<bool>("OnPlatform");

                    b.Property<string>("OriginBPFile");

                    b.Property<int>("ProvinceId");

                    b.Property<string>("ProvinceName");

                    b.Property<int>("RefenceId");

                    b.Property<DateTime>("RegisterDateTime");

                    b.Property<int>("Revenue");

                    b.Property<bool>("ShowSecurityInfo");

                    b.Property<int>("SourceId");

                    b.Property<string>("Tags");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<int>("UserId");

                    b.Property<int>("Valuation");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectContributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avator");

                    b.Property<int>("ContributorType");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsColsed");

                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectContributors");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectPropetry", b =>
                {
                    b.Property<int>("ProjectId");

                    b.Property<string>("Key")
                        .HasMaxLength(100);

                    b.Property<string>("Value")
                        .HasMaxLength(100);

                    b.Property<string>("Text");

                    b.HasKey("ProjectId", "Key", "Value");

                    b.ToTable("ProjectPropetries");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectViewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avator");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectViewers");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectVisableRule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProjectId");

                    b.Property<string>("Tags");

                    b.Property<bool>("Visable");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId")
                        .IsUnique();

                    b.ToTable("ProjectVisableRules");
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectContributor", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("ProjectContributors")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectPropetry", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("ProjectPropetries")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectViewer", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithMany("ProjectViewers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project.Domain.AggregatesModel.ProjectVisableRule", b =>
                {
                    b.HasOne("Project.Domain.AggregatesModel.Project")
                        .WithOne("ProjectVisableRule")
                        .HasForeignKey("Project.Domain.AggregatesModel.ProjectVisableRule", "ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
