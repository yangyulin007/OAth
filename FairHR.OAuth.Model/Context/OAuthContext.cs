using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairHR.OAuth.Model.Entities;

namespace FairHR.OAuth.Model.Context
{
    public class OAuthContext : DbContext
    {
        public OAuthContext() : base("OAuthContext")
        {

        }
        public virtual DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerNamee)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerShort)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ProviceId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TwoCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ThreeCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerType)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Hiberarchy)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Qualitys)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Induster)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.About)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BusinessCompany)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FinanceCompany)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.RegisterAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.OfficeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CompanyBack)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerService)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BussinessProtect)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PaymentMan)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.RecordsMan)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FiveOneMan)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FINANCEMAN)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.remark)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.staffNeedInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AddUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.UpdateUserId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.IsDelete)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Customer>()
                .Property(e => e.StaffNeedInforemark)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CusInvoiceType)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AuditStatus)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AuditorInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.AuditorId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.PaySideName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.ProducType)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TaxPayerType)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.BankName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.TaxPayerId)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.MobliePhone)
                .IsUnicode(false);
        }
    }
}