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
    
    public partial class team12Entities : DbContext
    {
        public team12Entities()
            : base("name=team12Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABOUTU> ABOUTUS { get; set; }
        public virtual DbSet<CONTACT> CONTACTs { get; set; }
        public virtual DbSet<DISTRICT> DISTRICTs { get; set; }
        public virtual DbSet<FEATURE> FEATUREs { get; set; }
        public virtual DbSet<IMAGE> IMAGES { get; set; }
        public virtual DbSet<PICTURE> PICTUREs { get; set; }
        public virtual DbSet<PROJECT_STATUS> PROJECT_STATUS { get; set; }
        public virtual DbSet<PROPERTY> PROPERTies { get; set; }
        public virtual DbSet<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
        public virtual DbSet<PROPERTY_TYPE> PROPERTY_TYPE { get; set; }
        public virtual DbSet<STREET> STREETs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<WARD> WARDs { get; set; }
    }
}
