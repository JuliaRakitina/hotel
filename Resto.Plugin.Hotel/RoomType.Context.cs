﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resto.Plugin.Hotel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestoEntities : DbContext
    {
        public RestoEntities()
            : base(ConnectionStringBuilder.Construct("RoomType"))
        {
            //Disable initializer
            Database.SetInitializer<RestoEntities>(null);
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //  throw new UnintentionalCodeFirstException();
            modelBuilder.Entity<HotelRoomType>().ToTable("HotelRoomType");
        }
    
        public virtual DbSet<HotelRoomType> HotelRoomType { get; set; }
    }
}
