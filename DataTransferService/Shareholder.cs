namespace DataTransferService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shareholder")]
    public partial class Shareholder
    {
        public int Id { get; set; }

        public int ApplicationFormId { get; set; }

        public int? Type { get; set; }

        public string Designation { get; set; }

        public double? SharesPercentage { get; set; }

        [Column("_CreatedBy")]
        [Required]
        public string C_CreatedBy { get; set; }

        [Column("_UpdatedBy")]
        [Required]
        public string C_UpdatedBy { get; set; }

        [Column("_CreatedAt")]
        public DateTime C_CreatedAt { get; set; }

        [Column("_UpdatedAt")]
        public DateTime C_UpdatedAt { get; set; }
    }
}
