namespace LogicServer.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("FAIRMANAGER.SO_SOCIALSECURITY")]
    public partial class SO_SOCIALSECURITY
    {
        [Key]
        [StringLength(20)]
        public string PKID { get; set; }

        [StringLength(32)]
        public string APPLYID { get; set; }

        [StringLength(32)]
        public string CUSTOMERCODE { get; set; }

        [StringLength(50)]
        public string THREECODE { get; set; }

        [StringLength(10)]
        public string CITYNAME { get; set; }

        [StringLength(20)]
        public string EMPLOYEENAME { get; set; }

        [StringLength(10)]
        public string SEX { get; set; }

        [StringLength(10)]
        public string NATIONAL { get; set; }

        [StringLength(18)]
        public string MANCARD { get; set; }

        [StringLength(10)]
        public string AGE { get; set; }

        [StringLength(10)]
        public string DEGREE { get; set; }

        [StringLength(30)]
        public string CONTACT { get; set; }

        [StringLength(50)]
        public string SSCARD { get; set; }

        [StringLength(50)]
        public string SSCOMPUTENO { get; set; }

        [StringLength(50)]
        public string MINUMBER { get; set; }

        [StringLength(50)]
        public string GJCARD { get; set; }

        [StringLength(10)]
        public string BELONGCITY { get; set; }

        [StringLength(100)]
        public string BELONGADDRESS { get; set; }

        [StringLength(10)]
        public string SSHISTORY { get; set; }

        public decimal? SSFEES { get; set; }

        [StringLength(20)]
        public string INSURANCETYPE { get; set; }

        [StringLength(10)]
        public string SSTYPE { get; set; }

        [StringLength(10)]
        public string SSYEAR { get; set; }

        [StringLength(200)]
        public string SSREMARK { get; set; }

        public decimal? BANLISTATUS { get; set; }

        public decimal? ISTOINSURANCE { get; set; }

        [StringLength(10)]
        public string ENDYEAR { get; set; }

        [StringLength(100)]
        public string REMARK1 { get; set; }

        [StringLength(100)]
        public string REMARK2 { get; set; }

        [StringLength(100)]
        public string REMARK3 { get; set; }

        [StringLength(100)]
        public string REMARK4 { get; set; }

        [StringLength(100)]
        public string REMARK5 { get; set; }

        [StringLength(100)]
        public string REMARK6 { get; set; }

        public decimal? EXPORTTIMES { get; set; }

        public decimal? ASSIGNSUPPLIER { get; set; }

        public decimal? SHOULISTATUS { get; set; }

        [StringLength(100)]
        public string SHOULINOTE { get; set; }

        [StringLength(100)]
        public string BANLINOTE { get; set; }

        public decimal? CEDAN { get; set; }

        [StringLength(100)]
        public string CEDANNOTE { get; set; }

        [StringLength(10)]
        public string BUJIAOSTARTYEAR { get; set; }

        [StringLength(10)]
        public string BUJIAOENDYEAR { get; set; }

        [StringLength(10)]
        public string GJTYPE { get; set; }

        public decimal? GONGJIJINFEE { get; set; }

        [StringLength(10)]
        public string GJYEAR { get; set; }

        [StringLength(10)]
        public string GJSTARTYEAR { get; set; }

        [StringLength(10)]
        public string GJENDYEAR { get; set; }

        public decimal? COPANYRATE { get; set; }

        public decimal? PERSONRATE { get; set; }

        [StringLength(32)]
        public string EMPLOYEEID { get; set; }

        public DateTime? SHOULIDATE { get; set; }

        public DateTime? CEDANDATE { get; set; }

        [StringLength(20)]
        public string BATCHNO { get; set; }

        [StringLength(32)]
        public string SHOULIPERSON { get; set; }

        public decimal? APPLYTYPE { get; set; }

        [StringLength(100)]
        public string SBZCTYPE { get; set; }

        [StringLength(100)]
        public string GGJZCTYPE { get; set; }

        [StringLength(10)]
        public string ISKEHUCEDAN { get; set; }

        [StringLength(50)]
        public string SUPPLIERCODE { get; set; }

        [StringLength(50)]
        public string SBAGAINAPPLY { get; set; }

        [StringLength(50)]
        public string GJJAGAINAPPLY { get; set; }

        [StringLength(50)]
        public string SBEXCPITON { get; set; }

        [StringLength(50)]
        public string GJJEXCPITON { get; set; }
    }
}
