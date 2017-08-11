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
        /// ��ˮ��
        /// </summary>
        [Key]
        [StringLength(32)]
        public string PKID { get; set; }

        /// <summary>
        /// Ա��ID
        /// </summary>
        [StringLength(32)]
        public string EMPLOYEEID { get; set; }

        /// <summary>
        /// ��Ч����
        /// </summary>
        public DateTime? STARTDATE { get; set; }

        /// <summary>
        /// ʧЧ����
        /// </summary>
        public DateTime? ENDDATE { get; set; }

        /// <summary>
        /// �籣״̬
        /// </summary>
        public decimal? STATE { get; set; }

        /// <summary>
        /// �籣���Ժ�
        /// </summary>
        [StringLength(50)]
        public string SSCOMPUTENO { get; set; }

        /// <summary>
        /// ���֤��
        /// </summary>
        [StringLength(18)]
        public string MANCARD { get; set; }

        /// <summary>
        /// �籣���
        /// </summary>
        [StringLength(20)]
        public string SSCARD { get; set; }

        /// <summary>
        /// �籣���ɹ�˾
        /// </summary>
        [StringLength(50)]
        public string SSCOMPANY { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [StringLength(20)]
        public string GJCARD { get; set; }

        /// <summary>
        /// ���ɻ���
        /// </summary>
        public decimal? PAYFEES { get; set; }

        /// <summary>
        /// �籣����
        /// </summary>
        [StringLength(50)]
        public string SSTYPE { get; set; }

        /// <summary>
        /// ���б���
        /// </summary>
        public decimal? AREAID { get; set; }

        /// <summary>
        /// ���ɳ���
        /// </summary>
        [StringLength(50)]
        public string JOINCITY { get; set; }

        /// <summary>
        /// �ڼ�
        /// </summary>
        [StringLength(14)]
        public string BACKTIME { get; set; }

        /// <summary>
        /// �������� 1�籣  2����
        /// </summary>
        public decimal? OPERATETYPE { get; set; }

        /// <summary>
        /// �����ID
        /// </summary>
        [StringLength(32)]
        public string ADDUSERID { get; set; }

        /// <summary>
        /// �޸���ID
        /// </summary>
        [StringLength(32)]
        public string UPDATEUSERID { get; set; }

        /// <summary>
        /// �Ƿ�ɾ�� 0�� 1��
        /// </summary>
        public decimal? ISDELETE { get; set; }

        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime? ADDTIME { get; set; }

        /// <summary>
        /// �޸�ʱ��
        /// </summary>
        public DateTime? UPDATETIME { get; set; }

        /// <summary>
        /// �Ƿ���Ч 0��Ч 1��Ч
        /// </summary>
        public decimal? ISACTIVE { get; set; }

        /// <summary>
        /// �Ƿ��籣0 �籣  1������
        /// </summary>
        public decimal? ISSSTYPE { get; set; }

        /// <summary>
        /// �Ƿ��Ѷ��� 1 ��
        /// </summary>
        public decimal? ISCHECKED { get; set; }

        /// <summary>
        /// �Ƿ����ڲ� 1 ��
        /// </summary>
        public decimal? ISINHISTORY { get; set; }
    }
}
