namespace Supply_chain_management_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("History")]
    public partial class History
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string SubjectId { get; set; }

        [Required]
        [StringLength(128)]
        public string SubjectName { get; set; }

        [StringLength(50)]
        public string Activity { get; set; }

        [StringLength(128)]
        public string OldValue { get; set; }

        [StringLength(128)]
        public string NewValue { get; set; }

        public DateTime? PreUpdateDate { get; set; }

        public DateTime NewUpdateDate { get; set; }

        [StringLength(128)]
        public string EditedBy { get; set; }
    }
}
