namespace DataTransferService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoanApplicationContext : DbContext
    {
        public LoanApplicationContext()
            : base("name=LoanApplicationConnection")
        {
        }

        public virtual DbSet<ApplicationForm> ApplicationForms { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Buyer> Buyers { get; set; }
        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<CibReportItem> CibReportItems { get; set; }
        public virtual DbSet<ExistingLoan> ExistingLoans { get; set; }
        public virtual DbSet<FixedAsset> FixedAssets { get; set; }
        public virtual DbSet<LoanFacility> LoanFacilities { get; set; }
        public virtual DbSet<LoanProduct> LoanProducts { get; set; }
        public virtual DbSet<Machinery> Machineries { get; set; }
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<Shareholder> Shareholders { get; set; }
        public virtual DbSet<StockItem> StockItems { get; set; }
        public virtual DbSet<Successor> Successors { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
