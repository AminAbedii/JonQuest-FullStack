﻿// <auto-generated />
using System;
using JobQuest.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobQuest.DataLayer.Migrations
{
    [DbContext(typeof(JobQuestContext))]
    [Migration("20250205090537_mig_editCompany")]
    partial class mig_editCompany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Advertisement", b =>
                {
                    b.Property<int>("AdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdId"));

                    b.Property<string>("AdTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExprienceId")
                        .HasColumnType("int");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<int?>("MilitaryPositionId")
                        .HasColumnType("int");

                    b.Property<string>("PicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SalaryId")
                        .HasColumnType("int");

                    b.Property<int>("SexId")
                        .HasColumnType("int");

                    b.Property<int>("WorkinghoursId")
                        .HasColumnType("int");

                    b.HasKey("AdId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DegreeId");

                    b.HasIndex("ExprienceId");

                    b.HasIndex("MilitaryPositionId");

                    b.HasIndex("SalaryId");

                    b.HasIndex("SexId");

                    b.HasIndex("WorkinghoursId");

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"));

                    b.Property<string>("CityTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("CompanyId");

                    b.HasIndex("RoleId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DegreeId"));

                    b.Property<string>("DegreeTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DegreeId");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Exprience", b =>
                {
                    b.Property<int>("ExprienceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExprienceId"));

                    b.Property<string>("ExprienceTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExprienceId");

                    b.ToTable("Expriences");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.MilitaryPosition", b =>
                {
                    b.Property<int>("MilitaryPositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MilitaryPositionId"));

                    b.Property<string>("MilitaryPositionTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MilitaryPositionId");

                    b.ToTable("MilitaryPositions");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Salary", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaryId"));

                    b.Property<string>("SalaryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalaryId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Sex", b =>
                {
                    b.Property<int>("SexId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SexId"));

                    b.Property<string>("SexTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SexId");

                    b.ToTable("Sexes");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Workinghours", b =>
                {
                    b.Property<int>("WorkinghoursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkinghoursId"));

                    b.Property<string>("WorkinghoursTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkinghoursId");

                    b.ToTable("Workinghours");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Advertisement", b =>
                {
                    b.HasOne("JobQuest.DataLayer.Entity.Category", "Category")
                        .WithMany("Advertisements")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.City", "City")
                        .WithMany("Advertisements")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.Company", "Company")
                        .WithMany("Advertisements")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.Degree", "Degree")
                        .WithMany("Advertisements")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.Exprience", "Exprience")
                        .WithMany("Advertisements")
                        .HasForeignKey("ExprienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.MilitaryPosition", "MilitaryPosition")
                        .WithMany("Advertisements")
                        .HasForeignKey("MilitaryPositionId");

                    b.HasOne("JobQuest.DataLayer.Entity.Salary", "Salary")
                        .WithMany("Advertisements")
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.Sex", "Sex")
                        .WithMany("Advertisements")
                        .HasForeignKey("SexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobQuest.DataLayer.Entity.Workinghours", "Workinghours")
                        .WithMany("Advertisements")
                        .HasForeignKey("WorkinghoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("Company");

                    b.Navigation("Degree");

                    b.Navigation("Exprience");

                    b.Navigation("MilitaryPosition");

                    b.Navigation("Salary");

                    b.Navigation("Sex");

                    b.Navigation("Workinghours");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Company", b =>
                {
                    b.HasOne("JobQuest.DataLayer.Entity.Role", "Role")
                        .WithMany("Companies")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Category", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.City", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Company", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Degree", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Exprience", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.MilitaryPosition", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Role", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Salary", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Sex", b =>
                {
                    b.Navigation("Advertisements");
                });

            modelBuilder.Entity("JobQuest.DataLayer.Entity.Workinghours", b =>
                {
                    b.Navigation("Advertisements");
                });
#pragma warning restore 612, 618
        }
    }
}
