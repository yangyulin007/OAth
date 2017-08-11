namespace LogicServer.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// SO_EMPLOYEESSOCIAL POCO type.
    /// this table stored employee applied social security info.
    /// </summary>
    [Table("FAIRMANAGER.SO_EMPLOYEESSOCIAL")]
    public partial class SO_EMPLOYEESSOCIAL
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [Key]
        [StringLength(32)]
        public string PKID { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [StringLength(32)]
        public string EMPLOYEEID { get; set; }

        /// <summary>
        /// 生效日期
        /// </summary>
        public DateTime? STARTDATE { get; set; }

        /// <summary>
        /// 失效日期
        /// </summary>
        public DateTime? ENDDATE { get; set; }

        /// <summary>
        /// 社保状态
        /// </summary>
        public decimal? STATE { get; set; }

        /// <summary>
        /// 社保电脑号
        /// </summary>
        [StringLength(50)]
        public string SSCOMPUTENO { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [StringLength(18)]
        public string MANCARD { get; set; }

        /// <summary>
        /// 社保编号
        /// </summary>
        [StringLength(20)]
        public string SSCARD { get; set; }

        /// <summary>
        /// 社保缴纳公司
        /// </summary>
        [StringLength(50)]
        public string SSCOMPANY { get; set; }

        /// <summary>
        /// 公积金编号
        /// </summary>
        [StringLength(20)]
        public string GJCARD { get; set; }

        /// <summary>
        /// 缴纳基数
        /// </summary>
        public decimal? PAYFEES { get; set; }

        /// <summary>
        /// 社保类型
        /// </summary>
        [StringLength(50)]
        public string SSTYPE { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        public decimal? AREAID { get; set; }

        /// <summary>
        /// 缴纳城市
        /// </summary>
        [StringLength(50)]
        public string JOINCITY { get; set; }

        /// <summary>
        /// 期间
        /// </summary>
        [StringLength(14)]
        public string BACKTIME { get; set; }

        /// <summary>
        /// 操作类型 1社保  2补缴
        /// </summary>
        public decimal? OPERATETYPE { get; set; }

        /// <summary>
        /// 添加人ID
        /// </summary>
        [StringLength(32)]
        public string ADDUSERID { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [StringLength(32)]
        public string UPDATEUSERID { get; set; }

        /// <summary>
        /// 是否删除 0否 1是
        /// </summary>
        public decimal? ISDELETE { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? ADDTIME { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UPDATETIME { get; set; }

        /// <summary>
        /// 是否有效 0有效 1无效
        /// </summary>
        public decimal? ISACTIVE { get; set; }

        /// <summary>
        /// 是否社保0 社保  1公积金
        /// </summary>
        public decimal? ISSSTYPE { get; set; }

        /// <summary>
        /// 是否已对账 1 是
        /// </summary>
        public decimal? ISCHECKED { get; set; }

        /// <summary>
        /// 是否已在册 1 是
        /// </summary>
        public decimal? ISINHISTORY { get; set; }
    }
}
