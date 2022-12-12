namespace Supply_chain_management_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(20)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(128)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(128)]
        public string ProductUnit { get; set; }

        public int? ProductQuantity { get; set; }

        [StringLength(128)]
        public string ProductDocument { get; set; }

        public decimal? ProductUnitPrice { get; set; }

        public decimal? TotalCost { get; set; }

        public DateTime ProductCreateDate { get; set; }

        public int ProductStatus { get; set; }
    }
    
}
