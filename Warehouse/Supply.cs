//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warehouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supply
    {
        public Nullable<int> Warehouse_FK { get; set; }
        public Nullable<int> Supplier_FK { get; set; }
        public int Product_FK { get; set; }
        public int Product_Supply_FK { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<System.DateTime> ProDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Supply_Permit Supply_Permit { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}