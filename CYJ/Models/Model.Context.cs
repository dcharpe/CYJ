﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYJ.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class cyjEntities : DbContext
    {
        public cyjEntities()
            : base("name=cyjEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ABOUT> ABOUTs { get; set; }
        public virtual DbSet<CorpsMemberExperience> CorpsMemberExperiences { get; set; }
        public virtual DbSet<ExternalAffair> ExternalAffairs { get; set; }
        public virtual DbSet<OpEx> OpExes { get; set; }
        public virtual DbSet<RAD> RADs { get; set; }
        public virtual DbSet<Revenue> Revenues { get; set; }
        public virtual DbSet<ServiceDelivery> ServiceDeliveries { get; set; }
    }
}
