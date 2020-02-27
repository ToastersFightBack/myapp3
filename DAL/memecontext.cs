using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using myapp.Models;

namespace myapp.DAL
{
    public class memecontext : DbContext
    {

        public memecontext() : base("memecontext")
        {
        }

        public DbSet<Funny> Funny { get; set; }
        public DbSet<Notfunny> Notfunny { get; set; }
        public DbSet<Shinbreaker> Shinbreaker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
    }
}