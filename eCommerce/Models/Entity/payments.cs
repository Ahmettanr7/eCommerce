//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eCommerce.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class payments
    {
        public int id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> payment_type { get; set; }
        public Nullable<System.DateTime> date_ { get; set; }
        public Nullable<bool> isok { get; set; }
        public string approve_code { get; set; }
        public Nullable<decimal> payment_total { get; set; }
    
        public virtual orders orders { get; set; }
    }
}