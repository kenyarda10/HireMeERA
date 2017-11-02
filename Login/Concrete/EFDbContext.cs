using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Login.Concrete
{
    public class EFDbContext : DbContext { 
        public DbSet<Posting> Postings { get; set; }
    }
}