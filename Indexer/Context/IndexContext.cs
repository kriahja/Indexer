using Indexer.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Indexer.dal
{
    public class IndexContext : DbContext
    {
        public IndexContext() : base("IndexContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paths>().HasMany(c => c.Words).WithMany();
            modelBuilder.Entity<Words>().HasMany(c => c.Paths).WithMany();
        }

        public DbSet<Paths> Paths { get; set; }
        public DbSet<Words> Words { get; set; }

    }
}
