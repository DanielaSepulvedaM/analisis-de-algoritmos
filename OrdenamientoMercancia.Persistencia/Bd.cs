using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace OrdenamientoMercancia.Persistencia
{
    public partial class Bd : DbContext
    {
        public Bd()
            : base("name=Bd")
        {
        }

        public virtual DbSet<Shipment> Shipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipment>()
                .Property(e => e.shipmentnum)
                .IsUnicode(false);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.SndrCity)
                .IsUnicode(false);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.RecCity)
                .IsUnicode(false);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.OriginalWeight)
                .HasPrecision(10, 2);
        }
    }
}
