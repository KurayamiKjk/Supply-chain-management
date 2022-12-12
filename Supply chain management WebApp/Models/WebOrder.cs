namespace Supply_chain_management_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WebOrder")]
    public partial class WebOrder
    {
        [Key]
        [StringLength(50)]
        public string OrderId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string AgentId { get; set; }

        [Required]
        [StringLength(128)]
        public string AgentName { get; set; }

        public int AgentNumber { get; set; }

        [Required]
        [StringLength(128)]
        public string AgentEmail { get; set; }

        [StringLength(128)]
        public string AgentAddress { get; set; }

        public DateTime CreateDate { get; set; }

        public decimal TotalPrice { get; set; }

        public int PaymentStatus { get; set; }

        public DateTime? PayDate { get; set; }

        public int OrderStatus { get; set; }
    }
}
