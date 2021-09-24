namespace OrdenamientoMercancia.Persistencia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shipment")]
    public partial class Shipment
    {
        public int ID { get; set; }

        [Required]
        [StringLength(21)]
        public string shipmentnum { get; set; }

        public DateTime? ShipmentDate { get; set; }

        [StringLength(23)]
        public string SndrCity { get; set; }

        [StringLength(30)]
        public string RecCity { get; set; }

        public decimal OriginalWeight { get; set; }
    }
}
