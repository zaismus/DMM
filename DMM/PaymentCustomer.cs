//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PaymentCustomer
    {
        public int ID { get; set; }
        public Nullable<int> ID_Supplier { get; set; }
        public string SupplierName { get; set; }
        public Nullable<double> Payment { get; set; }
        public Nullable<System.DateTime> DateT { get; set; }
    
        public virtual TB_Customers TB_Customers { get; set; }
    }
}
