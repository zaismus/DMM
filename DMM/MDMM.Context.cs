﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBDMMEntities : DbContext
    {
        public DBDMMEntities()
            : base("name=DBDMMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Debit_Suppliers> Debit_Suppliers { get; set; }
        public virtual DbSet<PaymentSupplier> PaymentSuppliers { get; set; }
        public virtual DbSet<TB_Suppliers> TB_Suppliers { get; set; }
        public virtual DbSet<Debit_Customers> Debit_Customers { get; set; }
        public virtual DbSet<PaymentCustomer> PaymentCustomers { get; set; }
        public virtual DbSet<TB_Customers> TB_Customers { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
    }
}
