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

        public System.Data.Entity.DbSet<Indexer.Models.Paths> Paths { get; set; }
        public System.Data.Entity.DbSet<Indexer.Models.Words> Words { get; set; }
    }
}
