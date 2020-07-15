﻿using IdentityServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.DbContexts
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext(DbContextOptions<MasterDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //seed data
            CompaniesSeed(builder);
        }

        public DbSet<Company> Companies { get; set; }

        private void CompaniesSeed(ModelBuilder builder)
        {

            var lalita = new Company
            {
                Id=1,
                CompanyName = "lalita",
                UserId = "1",
                DatabaseName = "LalitaDatabase",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };

            builder.Entity<Company>()
              .HasData(lalita);

        }
    }
}
