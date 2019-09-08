﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRPayrolApp.Models
{
    public class HRPayrollDbContext : IdentityDbContext<Worker>
    {
        public HRPayrollDbContext(DbContextOptions<HRPayrollDbContext> dbContextOptions) : base(dbContextOptions) { }

        //public DbSet<Bonus> Bonus { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<WorkerDismiss> WorkerDismisses { get; set; }
        public DbSet<Dismiss> Dismisses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Escape> Escapes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MaritalStatus> MaritalStatuses { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<WorkerAbsens> WorkerAbsens { get; set; }
        public DbSet<CompanyWorkPlaceAbsens> CompanyWorkPlaceAbsens { get; set; }

        public DbSet<CompanyWorkPlaceBonus> CompanyWorkPlaceBonus { get; set; }

        public DbSet<WorkerBonus> WorkerBonus { get; set; }

        public DbSet<CompanyWorkPlace> CompanyWorkPlaces { get; set; }
        public DbSet<Absens> Absens { get; set; }
        public DbSet<OldWorkPlace> OldWorkPlaces { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Education>().HasData(
                new Education { EducationId = 1, EducationName = "Bakalavr" },
                new Education { EducationId = 2, EducationName = "Magistr" }
                );

            builder.Entity<Gender>().HasData(
                new Gender { GenderId = 1, GenderName = "Male" },
                new Gender { GenderId = 2, GenderName = "Female" },
                new Gender { GenderId = 3, GenderName = "Multiple" }
                );

            builder.Entity<MaritalStatus>().HasData(
                new MaritalStatus { MaritalStatusId = 1, MaritalStatusName = "Marrid" },
                new MaritalStatus { MaritalStatusId = 2, MaritalStatusName = "Single" }
                );

            builder.Entity<Company>().HasData(
                new Company { ID = 1, Name = "Sinteks" }
                );

            builder.Entity<Department>().HasData(
                new Department { ID = 1, CompanyId = 1, Name = "IT" },
                new Department { ID = 2, CompanyId = 1, Name = "Programmer" }
                );

            builder.Entity<Position>().HasData(
                new Position { ID = 1, DepartmentId = 2, Name = "Junior Programmer", Salary = 1000 },
                new Position { ID = 2, DepartmentId = 2, Name = "Middle Programmer", Salary = 1500 },
                new Position { ID = 3, DepartmentId = 2, Name = "Senior Programmer", Salary = 3500 }
                );
        }


    }
}
