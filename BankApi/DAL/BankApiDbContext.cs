using BankApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.DAL
{
    public class BankApiDbContext : DbContext
    {
        public BankApiDbContext(DbContextOptions<BankApiDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
