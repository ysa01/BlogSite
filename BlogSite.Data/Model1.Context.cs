﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSite.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BLOG_DBEntities : DbContext
    {
        public BLOG_DBEntities()
            : base("name=BLOG_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORİ> CATEGORİ { get; set; }
        public virtual DbSet<COMMENTS> COMMENTS { get; set; }
        public virtual DbSet<CONTENTFILES> CONTENTFILES { get; set; }
        public virtual DbSet<CONTENTS> CONTENTS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USER_ROLE> USER_ROLE { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
    }
}
