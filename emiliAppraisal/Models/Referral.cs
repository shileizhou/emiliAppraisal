namespace emiliAppraisal.Models

{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Referral")]
    public partial class Referral
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CMHCNO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(26)]
        public string APIDSTMP { get; set; }

        [Required]
        [StringLength(2)]
        public string ReferralStatus { get; set; }

        [Required]
        [StringLength(2)]
        public string AccountStatus { get; set; }

        [Required]
        [StringLength(10)]
        public string UserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Borrower { get; set; }

        [Required]
        [StringLength(50)]
        public string Property { get; set; }

        [Required]
        [StringLength(50)]
        public string Lender { get; set; }

        [StringLength(2)]
        public string AppraisalStatus { get; set; }

        public int SortingColumn { get; set; }

        public string RegionCode { get; set; }

        public string PAIRStatus { get; set; }

        [Required]
        [StringLength(2)]
        public string AppType { get; set; }

    }
}
