﻿using Ecommerce.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Ecommerce.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(x=>x.Name).IsUnique();
        }
    }
} 
   