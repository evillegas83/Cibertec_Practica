﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebContextDb : DbContext
    {
        public WebContextDb() : base("name=WebDeveloperConnectionString")
        {
            //Database.SetInitializer(new WebDeveloperInitializer());
        }

        public DbSet<Categories> Categorie { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Products> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
