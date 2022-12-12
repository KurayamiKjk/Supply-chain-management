namespace Supply_chain_management_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [StringLength(50)]
        public string AgentId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string AgentName { get; set; }

        public int AgentNumber { get; set; }

        [Required]
        [StringLength(128)]
        public string AgentEmail { get; set; }

        [StringLength(128)]
        public string AgentAddress { get; set; }

        public DateTime AgentJoinDate { get; set; }

        public decimal? TotalRevenue { get; set; }

        public int AgentStatus { get; set; }
    }
}
