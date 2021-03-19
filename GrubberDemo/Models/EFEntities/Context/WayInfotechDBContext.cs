using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GrubberDemo.Models.EFEntities.Context
{
    public class WayInfotechDBContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
    }
}