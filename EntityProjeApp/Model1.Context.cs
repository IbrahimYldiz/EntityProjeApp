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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbEntityUrunEntities : DbContext
    {
        public DbEntityUrunEntities()
            : base("name=DbEntityUrunEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblSell> TblSell { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
    
        public virtual ObjectResult<string> Brand()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Brand");
        }
    }
}
