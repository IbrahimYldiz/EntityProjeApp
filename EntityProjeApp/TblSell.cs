//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProjeApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblSell
    {
        public int SELLId { get; set; }
        public Nullable<int> Product { get; set; }
        public Nullable<int> Customer { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual TblProduct TblProduct { get; set; }
        public virtual TblCustomer TblCustomer { get; set; }
    }
}
