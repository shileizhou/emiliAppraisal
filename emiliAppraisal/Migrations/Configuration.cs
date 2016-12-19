namespace emiliAppraisal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using emiliAppraisal.Models;
    using emiliAppraisal.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<emiliAppraisal.DAL.emiliDB>
    {        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(emiliAppraisal.DAL.emiliDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.Borrowers.AddOrUpdate(p => p.uid,
            //     new  Borrower { sin = 332123567, firstName = "Andy", lastName = "Zhou", marriedStatus = "", phoneNo = "6132221233", DOB = Convert.ToDateTime("12/08/2010") },
            //     new Borrower { sin = 332123567, firstName = "Ruixin", lastName = "Zhou", marriedStatus = "", phoneNo = "6132221255", DOB = Convert.ToDateTime("06/08/2013") },
            //     new Borrower { sin = 332123567, firstName = "Ruilin", lastName = "Zhou", marriedStatus = "", phoneNo = "6132221277", DOB = Convert.ToDateTime("08/08/2018") });

        }
    }
}
