namespace LogicServer.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FAIRMANAGER.SO_SOCIALSECURITYAPPLY")]
    public partial class SO_SOCIALSECURITYAPPLY
    {
        [Key]
        [StringLength(20)]
        public string APPLYID { get; set; }

        [StringLength(20)]
        public string EMPLOYID { get; set; }

        [StringLength(20)]
        public string EMPLOYNAME { get; set; }

        [StringLength(20)]
        public string CITYID { get; set; }

        [StringLength(50)]
        public string CITYNAME { get; set; }

        [StringLength(200)]
        public string APPLYREMARK { get; set; }

        public DateTime? APPLYDATE { get; set; }

        [StringLength(20)]
        public string AUDITID { get; set; }

        [StringLength(20)]
        public string AUDITNAME { get; set; }

        public DateTime? AUDITDATE { get; set; }

        [StringLength(200)]
        public string AUDITREMARK { get; set; }

        [StringLength(20)]
        public string DEALID { get; set; }

        [StringLength(20)]
        public string DEALNAME { get; set; }

        public DateTime? DEALDATE { get; set; }

        [StringLength(200)]
        public string DEALREMARK { get; set; }

        public decimal? APPLYSTATE { get; set; }

        [StringLength(100)]
        public string UPLOADFILE { get; set; }

        [StringLength(100)]
        public string APPLYNAME { get; set; }

        [StringLength(32)]
        public string FORMATID { get; set; }

        public DateTime CREATEDATE { get; set; }

        public decimal? EXPORTCOUNT { get; set; }

        public decimal? ISCREATESS { get; set; }

        public decimal? ISCREATECUSTOMER { get; set; }

        [StringLength(32)]
        public string CU_USERID { get; set; }

        [StringLength(20)]
        public string ISDECLARE { get; set; }

        public DateTime? CHEDANDATE { get; set; }

        [StringLength(100)]
        public string ATTACHMENT { get; set; }

        [StringLength(50)]
        public string SUPPLIERCODE { get; set; }
    }
}
