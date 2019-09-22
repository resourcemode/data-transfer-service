namespace DataTransferService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Case")]
    public partial class Case
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(20)]
        public string ReferenceNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime ApplicationDate { get; set; }

        public bool IsCompleted { get; set; }

        public Guid ProductId { get; set; }

        public Guid FacilityId { get; set; }

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
