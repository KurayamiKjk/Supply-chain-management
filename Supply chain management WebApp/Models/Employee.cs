namespace Supply_chain_management_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        public string UserPassword { get; set; }

        [Key]
        [Column(Order = 3)]
        public string UserFirstName { get; set; }

        [Key]
        [Column(Order = 4)]
        public string UserLastName { get; set; }

        public int? UserPhone { get; set; }

        [StringLength(128)]
        public string UserAddress { get; set; }

        public double? UserSalary { get; set; }
    }
}
