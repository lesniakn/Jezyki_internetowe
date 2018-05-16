using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WSIZ.Models;

namespace WSIZ.DAL
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        {

        }
        public DbSet<Przedmiot> Przedmiot { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}