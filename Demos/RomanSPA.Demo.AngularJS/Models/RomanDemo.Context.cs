﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RomanSPA.Demo.AngularJS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RomanSPAStarterKitEntities : DbContext
    {
        public RomanSPAStarterKitEntities()
            : base("name=RomanSPAStarterKitEntities")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<RomanSPAStarterKitEntities, Migrations.Configuration>());
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
