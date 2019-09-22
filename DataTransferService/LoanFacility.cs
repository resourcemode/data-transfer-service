namespace DataTransferService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoanFacility")]
    public partial class LoanFacility
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Order { get; set; }

        public bool IsEnabled { get; set; }
    }
}
