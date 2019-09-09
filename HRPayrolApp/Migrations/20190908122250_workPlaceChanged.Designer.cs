﻿// <auto-generated />
using System;
using HRPayrolApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HRPayrolApp.Migrations
{
    [DbContext(typeof(HRPayrollDbContext))]
    [Migration("20190908122250_workPlaceChanged")]
    partial class workPlaceChanged
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HRPayrolApp.Models.Absens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Absens");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Company", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Companies");

                    b.HasData(
                        new { ID = 1, Name = "Sinteks" }
                    );
                });

            modelBuilder.Entity("HRPayrolApp.Models.CompanyWorkPlace", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ChangedDate");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("PositionId");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PositionId");

                    b.ToTable("CompanyWorkPlaces");
                });

            modelBuilder.Entity("HRPayrolApp.Models.CompanyWorkPlaceAbsens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWorkPlaceId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("ExcusableAbsens");

                    b.Property<int>("UnExcusableAbsens");

                    b.HasKey("ID");

                    b.HasIndex("CompanyWorkPlaceId");

                    b.ToTable("CompanyWorkPlaceAbsens");
                });

            modelBuilder.Entity("HRPayrolApp.Models.CompanyWorkPlaceBonus", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BonusSalary");

                    b.Property<string>("CompanyWorkPlaceId");

                    b.HasKey("ID");

                    b.HasIndex("CompanyWorkPlaceId");

                    b.ToTable("CompanyWorkPlaceBonus");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CompanyId");

                    b.ToTable("Departments");

                    b.HasData(
                        new { ID = 1, CompanyId = 1, Name = "IT" },
                        new { ID = 2, CompanyId = 1, Name = "Programmer" }
                    );
                });

            modelBuilder.Entity("HRPayrolApp.Models.Dismiss", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Reason");

                    b.HasKey("ID");

                    b.ToTable("Dismisses");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Education", b =>
                {
                    b.Property<int>("EducationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EducationName");

                    b.HasKey("EducationId");

                    b.ToTable("Educations");

                    b.HasData(
                        new { EducationId = 1, EducationName = "Bakalavr" },
                        new { EducationId = 2, EducationName = "Magistr" }
                    );
                });

            modelBuilder.Entity("HRPayrolApp.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Born");

                    b.Property<string>("DistrictRegistration");

                    b.Property<int>("EducationId");

                    b.Property<string>("FatherName");

                    b.Property<int>("GenderId");

                    b.Property<string>("Image");

                    b.Property<int>("MaritalStatusId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("PersonalityCardEndDate");

                    b.Property<string>("PersonalityCardNumber");

                    b.Property<string>("Residence");

                    b.Property<string>("Surname");

                    b.HasKey("ID");

                    b.HasIndex("EducationId");

                    b.HasIndex("GenderId");

                    b.HasIndex("MaritalStatusId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Escape", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EscapeDate");

                    b.Property<string>("EscapeReason");

                    b.Property<string>("WorkerId");

                    b.HasKey("ID");

                    b.HasIndex("WorkerId");

                    b.ToTable("Escapes");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenderName")
                        .IsRequired();

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new { GenderId = 1, GenderName = "Male" },
                        new { GenderId = 2, GenderName = "Female" },
                        new { GenderId = 3, GenderName = "Multiple" }
                    );
                });

            modelBuilder.Entity("HRPayrolApp.Models.MaritalStatus", b =>
                {
                    b.Property<int>("MaritalStatusId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaritalStatusName")
                        .IsRequired();

                    b.HasKey("MaritalStatusId");

                    b.ToTable("MaritalStatuses");

                    b.HasData(
                        new { MaritalStatusId = 1, MaritalStatusName = "Marrid" },
                        new { MaritalStatusId = 2, MaritalStatusName = "Single" }
                    );
                });

            modelBuilder.Entity("HRPayrolApp.Models.Position", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Salary");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Positions");

                    b.HasData(
                        new { ID = 1, DepartmentId = 2, Name = "Junior Programmer", Salary = 1000m },
                        new { ID = 2, DepartmentId = 2, Name = "Middle Programmer", Salary = 1500m },
                        new { ID = 3, DepartmentId = 2, Name = "Senior Programmer", Salary = 3500m }
                    );
                });

            modelBuilder.Entity("HRPayrolApp.Models.Store", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("HRPayrolApp.Models.ViewModels.WorkPlaceViewModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("EnterDate");

                    b.Property<DateTime>("LeaveDate");

                    b.Property<string>("LeaveReason");

                    b.Property<string>("WorkName");

                    b.HasKey("ID");

                    b.ToTable("WorkPlaceViewModel");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Worker", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Account");

                    b.Property<DateTime>("BeginDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("EmployeeId");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PassText");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("PositionId");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PositionId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkerAbsens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AbsensId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Reason");

                    b.Property<string>("WorkerId");

                    b.HasKey("ID");

                    b.HasIndex("AbsensId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerAbsens");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkerBonus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BonusDate");

                    b.Property<decimal>("BonusSalary");

                    b.Property<string>("Reason")
                        .IsRequired();

                    b.Property<string>("WorkerId");

                    b.HasKey("ID");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerBonus");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkerDismiss", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyWorkPlaceID");

                    b.Property<int>("DismissId");

                    b.Property<string>("WorkerId");

                    b.HasKey("ID");

                    b.HasIndex("CompanyWorkPlaceID");

                    b.HasIndex("DismissId");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkerDismisses");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkPlace", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("EnterDate");

                    b.Property<DateTime>("LeaveDate");

                    b.Property<string>("LeaveReason");

                    b.Property<string>("WorkName");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId");

                    b.ToTable("WorkPlaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HRPayrolApp.Models.CompanyWorkPlace", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Employee", "Employee")
                        .WithMany("CompanyWorkPlaces")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRPayrolApp.Models.CompanyWorkPlaceAbsens", b =>
                {
                    b.HasOne("HRPayrolApp.Models.CompanyWorkPlace", "CompanyWorkPlace")
                        .WithMany("CompanyWorkPlaceAbsens")
                        .HasForeignKey("CompanyWorkPlaceId");
                });

            modelBuilder.Entity("HRPayrolApp.Models.CompanyWorkPlaceBonus", b =>
                {
                    b.HasOne("HRPayrolApp.Models.CompanyWorkPlace", "CompanyWorkPlace")
                        .WithMany("CompanyWorkPlaceBonus")
                        .HasForeignKey("CompanyWorkPlaceId");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Department", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Company", "Company")
                        .WithMany("Departments")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRPayrolApp.Models.Employee", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Education", "Education")
                        .WithMany("Employees")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.Gender", "Gender")
                        .WithMany("Employees")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.MaritalStatus", "MaritalStatus")
                        .WithMany("Employees")
                        .HasForeignKey("MaritalStatusId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRPayrolApp.Models.Escape", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Worker", "Worker")
                        .WithMany("Escapes")
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Position", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Department", "Department")
                        .WithMany("Workers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRPayrolApp.Models.Store", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Company", "Company")
                        .WithMany("Stores")
                        .HasForeignKey("CompanyID");
                });

            modelBuilder.Entity("HRPayrolApp.Models.Worker", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Employee", "Employee")
                        .WithOne("Worker")
                        .HasForeignKey("HRPayrolApp.Models.Worker", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkerAbsens", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Absens", "Absens")
                        .WithMany("WorkerAbsens")
                        .HasForeignKey("AbsensId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.Worker", "Worker")
                        .WithMany()
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkerBonus", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Worker", "Worker")
                        .WithMany("WorkerBonus")
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkerDismiss", b =>
                {
                    b.HasOne("HRPayrolApp.Models.CompanyWorkPlace")
                        .WithMany("WorkerDismisses")
                        .HasForeignKey("CompanyWorkPlaceID");

                    b.HasOne("HRPayrolApp.Models.Dismiss", "Dismiss")
                        .WithMany("WorkerDismisses")
                        .HasForeignKey("DismissId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.Worker", "Worker")
                        .WithMany("WorkerDismisses")
                        .HasForeignKey("WorkerId");
                });

            modelBuilder.Entity("HRPayrolApp.Models.WorkPlace", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Employee", "Employee")
                        .WithMany("WorkPlaces")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HRPayrolApp.Models.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HRPayrolApp.Models.Worker")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
