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
    
    public partial class invoice_details
    {
        public int id { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public Nullable<int> order_detail_id { get; set; }
        public Nullable<int> item_id { get; set; }
        public Nullable<int> amount { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public Nullable<decimal> line_total { get; set; }
    
        public virtual invoices invoices { get; set; }
        public virtual order_details order_details { get; set; }
        public virtual items items { get; set; }
    }
}