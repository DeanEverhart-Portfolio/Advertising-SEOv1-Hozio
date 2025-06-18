using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// _____ default (end) _____

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

// ___ project specific ____

using Hozio.Models;

// _________________________


namespace Hozio.data
{
    public class hdalContext : DbContext
    {
        public hdalContext() : base("hdalLocal") // : base("name of connection string")        

        {

        }

        public DbSet<contact1> contact1s { get; set; }

        public DbSet<client1> client1s { get; set; }

        public DbSet<contact> contacts { get; set; }

        public DbSet<ahref> ahrefs { get; set; }

        public DbSet<site> sites { get; set; }

        public DbSet<hog2> hog2s { get; set; }

        public DbSet<client> clients { get; set; }

        public DbSet<document> documents { get; set; }

        public DbSet<admin> admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}