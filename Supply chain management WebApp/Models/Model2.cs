using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Supply_chain_management_WebApp.Models
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<WebOrder> WebOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebOrder>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<WebOrder>()
                .Property(e => e.AgentId)
                .IsUnicode(false);

            modelBuilder.Entity<WebOrder>()
                .Property(e => e.AgentEmail)
                .IsUnicode(false);

            modelBuilder.Entity<WebOrder>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);
        }
    }
}
