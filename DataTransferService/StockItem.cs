namespace DataTransferService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockItem")]
    public partial class StockItem
    {
        public int Id { get; set; }

        public int ApplicationFormId { get; set; }

        public string ProductType { get; set; }

        public int? UnitsInStock { get; set; }

        public double? UnitSellingPrice { get; set; }

        public double? TotalPrice { get; set; }

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
