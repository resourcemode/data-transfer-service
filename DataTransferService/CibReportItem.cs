namespace DataTransferService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CibReportItem")]
    public partial class CibReportItem
    {
        public int Id { get; set; }

        public int CibReportApplicationFormId { get; set; }

        public string Name { get; set; }

        public string Nature { get; set; }

        public string Role { get; set; }

        public double? LimitAmount { get; set; }

        public string Os { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SanctionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryDate { get; set; }

        public string Status { get; set; }

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
