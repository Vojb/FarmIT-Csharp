﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmITApp.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FarmEntities : DbContext
    {
        public FarmEntities()
            : base("name=FarmEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Box> Box { get; set; }
        public DbSet<Building> Building { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}