﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trip_Adviser
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tripAdviserEntities : DbContext
    {
        public tripAdviserEntities()
            : base("name=tripAdviserEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FOOD> FOODs { get; set; }
        public virtual DbSet<HOTEL> HOTELs { get; set; }
        public virtual DbSet<HOTEL_OFFER> HOTEL_OFFER { get; set; }
        public virtual DbSet<PICTURE> PICTUREs { get; set; }
        public virtual DbSet<PLACE> PLACEs { get; set; }
        public virtual DbSet<RESTAURANT> RESTAURANTs { get; set; }
        public virtual DbSet<RESTAURANT_OFFER> RESTAURANT_OFFER { get; set; }
        public virtual DbSet<REVIEW_RATING> REVIEW_RATING { get; set; }
        public virtual DbSet<WEATHER> WEATHERs { get; set; }
    }
}
