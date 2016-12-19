namespace emiliAppraisal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "unitNo", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
        }
    }
}
