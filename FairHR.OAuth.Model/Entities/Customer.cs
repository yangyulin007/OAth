using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairHR.OAuth.Model.Entities
{
    [Table("FAIRMANAGER.CU_CUSTOMER")]
    public class Customer
    {
        [Key]
        [StringLength(32)]
        [Column("CUSTOMERID")]
        public string CustomerId { get; set; }

        [StringLength(32)]
        [Column("PARENTID")]
        public string ParentId { get; set; }

        [StringLength(100)]
        [Column("CUSTOMERNAME")]
        public string CustomerName { get; set; }

        [StringLength(100)]
        [Column("CUSTOMERNAMEE")]
        public string CustomerNamee { get; set; }

        [StringLength(50)]
        [Column("CUSTOMERCODE")]
        public string CustomerCode { get; set; }

        [StringLength(100)]
        [Column("CUSTOMERSHORT")]
        public string CustomerShort { get; set; }

        [StringLength(10)]
        [Column("PROVINCEID")]
        public string ProviceId { get; set; }

        [StringLength(10)]
        [Column("CITYID")]
        public string CityId { get; set; }

        [StringLength(50)]
        [Column("TWOCODE")]
        public string TwoCode { get; set; }

        [StringLength(500)]
        [Column("THREECODE")]
        public string ThreeCode { get; set; }

        [StringLength(32)]
        [Column("CUSTOMERTYPE")]
        public string CustomerType { get; set; }

        [StringLength(100)]
        [Column("ADDRESS")]
        public string Address { get; set; }

        [StringLength(32)]
        [Column("HIBERARCHY")]
        public string Hiberarchy { get; set; }

        [StringLength(50)]
        [Column("QUALITYS")]
        public string Qualitys { get; set; }

        [StringLength(32)]
        [Column("INDUSTRY")]
        public string Induster { get; set; }

        [StringLength(200)]
        [Column("ABOUT")]
        public string About { get; set; }

        [StringLength(32)]
        [Column("BUSINESSCOMPANY")]
        public string BusinessCompany { get; set; }

        [StringLength(32)]
        [Column("FINANCECOMPANY")]
        public string FinanceCompany { get; set; }

        [StringLength(100)]
        [Column("REGISTERADDRESS")]
        public string RegisterAddress { get; set; }

        [StringLength(50)]
        [Column("OFFICEADDRESS")]
        public string OfficeAddress { get; set; }

        [StringLength(500)]
        [Column("COMPANYBACK")]
        public string CompanyBack { get; set; }

        [StringLength(32)]
        [Column("CUSTOMERSERVICE")]
        public string CustomerService { get; set; }

        [StringLength(32)]
        [Column("BUSINESSPROTECT")]
        public string BussinessProtect { get; set; }

        [StringLength(32)]
        [Column("PAYMENTMAN")]
        public string PaymentMan { get; set; }

        [StringLength(32)]
        [Column("RECORDSMAN")]
        public string RecordsMan { get; set; }

        [StringLength(32)]
        [Column("FIVEONEMAN")]
        public string FiveOneMan { get; set; }

        [StringLength(32)]
        [Column("CUSTOMERID")]
        public string FINANCEMAN { get; set; }

        [StringLength(200)]
        [Column("REMARK")]
        public string remark { get; set; }

        [StringLength(50)]
        [Column("STAFFNEEDINFO")]
        public string staffNeedInfo { get; set; }

        [StringLength(32)]
        [Column("ADDUSERID")]
        public string AddUserId { get; set; }

        [StringLength(32)]
        [Column("UPDATEUSERID")]
        public string UpdateUserId { get; set; }
        [Column("ISDELETE")]
        public decimal? IsDelete { get; set; }
        [Column("ADDTIME")]
        public DateTime? AddTime { get; set; }
        [Column("UPDATETIME")]
        public DateTime?  UpdateTime{ get; set; }

        [StringLength(2000)]
        [Column("STAFFNEEDINFOREMARK")]
        public string  StaffNeedInforemark{ get; set; }
        [Column("CUSINVOICETYPE")]
        public decimal?  CusInvoiceType{ get; set; }
        [Column("AUDITSTATUS")]
        public decimal? AuditStatus { get; set; }

        [StringLength(200)]
        [Column("AUDITORINFO")]
        public string AuditorInfo { get; set; }
        [Column("AUDITORTIME")]
        public DateTime? AuditorTime { get; set; }

        [StringLength(32)]
        [Column("AUDITORID")]
        public string  AuditorId{ get; set; }

        [StringLength(1000)]
        [Column("PAYSIDENAME")]
        public string  PaySideName{ get; set; }

        [StringLength(30)]
        [Column("PRODUCTTYPE")]
        public string  ProducType{ get; set; }

        [StringLength(10)]
        [Column("TAXPAYERTYPE")]
        public string  TaxPayerType{ get; set; }

        [StringLength(30)]
        [Column("BANKACCOUNT")]
        public string  BankAccount{ get; set; }

        [StringLength(100)]
        [Column("BANKNAME")]
        public string  BankName{ get; set; }

        [StringLength(30)]
        [Column("TAXPAYERID")]
        public string  TaxPayerId{ get; set; }

        [StringLength(30)]
        [Column("MOBILEPHONE")]
        public string  MobliePhone{ get; set; }
    }
}