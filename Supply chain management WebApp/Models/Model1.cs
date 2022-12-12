using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Supply_chain_management_WebApp.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SupplyChainManagementDBModel")
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .Property(e => e.AgentId)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.AgentEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.TotalRevenue)
                .HasPrecision(18, 3);

            modelBuilder.Entity<History>()
                .Property(e => e.SubjectId)
                .IsUnicode(false);

            modelBuilder.Entity<History>()
                .Property(e => e.Activity)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.AgentId)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.PriceEach)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductDocument)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Product>()
                .Property(e => e.TotalCost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserPassword)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserFirstName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserLastName)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserAddress)
                .IsFixedLength();
        }

        public System.Data.Entity.DbSet<Supply_chain_management_WebApp.Models.CartItem> CartItems { get; set; }
    }
}
