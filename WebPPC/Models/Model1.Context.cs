﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPPC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class team12Entities1 : DbContext
    {
        public team12Entities1()
            : base("name=team12Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABOUTUS> ABOUTUS { get; set; }
        public virtual DbSet<CONTACT> CONTACT { get; set; }
        public virtual DbSet<DISTRICT> DISTRICT { get; set; }
        public virtual DbSet<FEATURE> FEATURE { get; set; }
        public virtual DbSet<IMAGES> IMAGES { get; set; }
        public virtual DbSet<PICTURE> PICTURE { get; set; }
        public virtual DbSet<PROJECT_STATUS> PROJECT_STATUS { get; set; }
        public virtual DbSet<PROPERTY> PROPERTY { get; set; }
        public virtual DbSet<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
        public virtual DbSet<PROPERTY_TYPE> PROPERTY_TYPE { get; set; }
        public virtual DbSet<STREET> STREET { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USER> USER { get; set; }
        public virtual DbSet<WARD> WARD { get; set; }
    }
}
