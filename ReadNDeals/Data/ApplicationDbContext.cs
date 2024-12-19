﻿using Microsoft.EntityFrameworkCore;
using ReadNDeals.Models;
using System.Runtime;
using System.Security.Cryptography.Xml;

namespace ReadNDeals.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Horror", DisplayOrder = 2 },
                new Category { Id = 3, Name = "SciFi", DisplayOrder = 3 }
            );
        }


    }
}