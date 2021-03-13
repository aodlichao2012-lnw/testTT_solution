using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tttest.Models;

namespace tttest.DbContexts
{
    public class Dbcon : DbContext
    {
        public Dbcon(DbContextOptions<Dbcon> options):base(options)
        {

        }

        public DbSet<Empolyee> empolyees { get; set; }
    }
}
