namespace emiliAppraisal.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using emiliAppraisal.Models;

    public partial class emiliDB : DbContext
    {
        public emiliDB()
            : base("name=emiliDB")
        {
            //Database.Initialize(true);

            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;

            this.Database.CommandTimeout = 3000;
            


            Database.SetInitializer<emiliDB>(new DropCreateDatabaseIfModelChanges<emiliDB>());

            //Database.SetInitializer<emiliDB>(new CreateDatabaseIfNotExists<emiliDB>());
            //Database.SetInitializer<emiliDB>(new DropCreateDatabaseAlways<emiliDB>());
            //Database.SetInitializer<emiliDB>(new SchoolDBInitializer());

        }


        public virtual DbSet<emiliAppraisal.Models.Person> Persons { get; set; }
        public virtual DbSet<emiliAppraisal.Models.Referral> Referrals { get; set; }
        public virtual DbSet<emiliAppraisal.Models.Application> Applications { get; set; }
        public virtual DbSet<emiliAppraisal.Models.Sales> Sales { get; set; }
        public virtual DbSet<emiliAppraisal.Models.Appraisal> Appraisals { get; set; }

        public System.Data.Entity.DbSet<emiliAppraisal.Models.Loan> Loans { get; set; }

        public virtual System.Data.Entity.DbSet<emiliAppraisal.Models.Address> Addresses { get; set; }

        public virtual System.Data.Entity.DbSet<emiliAppraisal.Models.Borrower> Borrowers { get; set; }
        public virtual System.Data.Entity.DbSet<emiliAppraisal.Models.Qualifying> Qualifyings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            #region referral table
            modelBuilder.Entity<Referral>()
                .Property(e => e.APIDSTMP)
                .IsFixedLength();

            modelBuilder.Entity<Referral>()
                .Property(e => e.ReferralStatus)
                .IsFixedLength();

            modelBuilder.Entity<Referral>()
                .Property(e => e.AccountStatus)
                .IsFixedLength();

            modelBuilder.Entity<Referral>()
                .Property(e => e.UserId)
                .IsFixedLength();

            modelBuilder.Entity<Referral>()
                .Property(e => e.Borrower)
                .IsUnicode(false);

            modelBuilder.Entity<Referral>()
                .Property(e => e.Property)
                .IsUnicode(false);

            modelBuilder.Entity<Referral>()
                .Property(e => e.Lender)
                .IsUnicode(false);

            modelBuilder.Entity<Referral>()
                .Property(e => e.AppraisalStatus)
                .IsFixedLength();

            modelBuilder.Entity<emiliAppraisal.Models.Referral>().Ignore(t => t.SortingColumn);

            modelBuilder.Entity<emiliAppraisal.Models.Referral>()
            .Property(t => t.RegionCode)
            .IsOptional()
            .HasColumnName("Region");


            #endregion


            #region Application table

            modelBuilder.Entity<Application>()
                        .HasKey(t => new { t.CMHCNO, t.APIDSTMP });

            #endregion

            #region Address table

            modelBuilder.Entity<Address>()
                        .HasKey(t => t.addressId);

            #endregion

            #region Property table

            modelBuilder.Entity<Property>()
                        .HasKey(t => t.propertyId);

            #endregion

            modelBuilder.Entity<Person>()
                        .HasKey(t => t.uid);

            modelBuilder.Entity<Loan>()
                        .HasKey(t => t.loanId);

            modelBuilder.Entity<Sales>()
                        .HasKey(t => new { t.propertyId, t.saleDate });

            modelBuilder.Entity<Appraisal>()
                        .HasKey(t => new { t.propertyId, t.appraisalDate });

        }


    }
}
