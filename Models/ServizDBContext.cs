using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proekt_v2.Models
{
    public class ServizDBContext : DbContext
    {
        public DbSet<Services> Services { get; set; }
        public DbSet<InRepair> InRepair { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
    }
}