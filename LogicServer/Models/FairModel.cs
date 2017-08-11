namespace LogicServer.Models
{
    using System.Data.Entity;

    /// <summary>
    /// Domain model of FYW100 database. When doing actual development we should set the proper dataset which is related
    /// with the project's domain.
    /// </summary>
    public partial class FairModel : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FairModel"/> class.
        /// </summary>
        public FairModel()
            : base("name=FairModel")
        {
        }

        /// <summary>
        /// Gets or sets use lazy loading for SO_EMPLOYEESSOCIAL table.
        /// </summary>
        public virtual DbSet<SO_EMPLOYEESSOCIAL> SO_EMPLOYEESSOCIAL { get; set; } // Virtual prefix will create dynamic proxy for lazy loading. The swith for lazy loading sould not be off.

        /// <inheritdoc/>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.PKID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.EMPLOYEEID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.STATE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.SSCOMPUTENO)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.MANCARD)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.SSCARD)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.SSCOMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.GJCARD)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.PAYFEES)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.SSTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.AREAID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.JOINCITY)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.BACKTIME)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.OPERATETYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.ADDUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.UPDATEUSERID)
                .IsUnicode(false);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.ISDELETE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.ISACTIVE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.ISSSTYPE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.ISCHECKED)
                .HasPrecision(38, 0);

            modelBuilder.Entity<SO_EMPLOYEESSOCIAL>()
                .Property(e => e.ISINHISTORY)
                .HasPrecision(38, 0);
        }
    }
}
