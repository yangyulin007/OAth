namespace LogicServer.Models
{
    using System.Data.Entity;

    /// <summary>
    /// 社保申报及信息
    /// </summary>
    public partial class SocialSecurityandApply : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialSecurityandApply"/> class.
        /// </summary>
        public SocialSecurityandApply()
            : base("name=SocialSecurityandApply")
        {
        }

        public virtual DbSet<SO_SOCIALSECURITY> SO_SOCIALSECURITY { get; set; }

        public virtual DbSet<SO_SOCIALSECURITYAPPLY> SO_SOCIALSECURITYAPPLY { get; set; }

        /// <summary>
        /// OnModelCreating
        /// </summary>
        /// <param name="modelBuilder">modelBuilder</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.PKID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.APPLYID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.CUSTOMERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.THREECODE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.CITYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.EMPLOYEENAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.NATIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.MANCARD)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.AGE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.DEGREE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.CONTACT)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SSCARD)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SSCOMPUTENO)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.MINUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJCARD)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BELONGCITY)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BELONGADDRESS)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SSHISTORY)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.INSURANCETYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SSYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SSREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BANLISTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.ISTOINSURANCE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.ENDYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.REMARK1)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.REMARK2)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.REMARK3)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.REMARK4)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.REMARK5)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.REMARK6)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.EXPORTTIMES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.ASSIGNSUPPLIER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SHOULISTATUS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SHOULINOTE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BANLINOTE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.CEDAN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.CEDANNOTE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BUJIAOSTARTYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BUJIAOENDYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJSTARTYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJENDYEAR)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.EMPLOYEEID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.BATCHNO)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SHOULIPERSON)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.APPLYTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SBZCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GGJZCTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.ISKEHUCEDAN)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SUPPLIERCODE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SBAGAINAPPLY)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJJAGAINAPPLY)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.SBEXCPITON)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITY>()
                .Property(e => e.GJJEXCPITON)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.APPLYID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.EMPLOYID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.EMPLOYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.CITYID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.CITYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.APPLYREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.AUDITID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.AUDITNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.AUDITREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.DEALID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.DEALNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.DEALREMARK)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.APPLYSTATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.UPLOADFILE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.APPLYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.FORMATID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.EXPORTCOUNT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.ISCREATESS)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.ISCREATECUSTOMER)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.CU_USERID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.ISDECLARE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.ATTACHMENT)
                .IsUnicode(false);

            modelBuilder.Entity<SO_SOCIALSECURITYAPPLY>()
                .Property(e => e.SUPPLIERCODE)
                .IsUnicode(false);
        }
    }
}
