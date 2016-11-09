namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeBalanceToPaymentInBills : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bills", "Payment", c => c.Single(nullable: false));
            DropColumn("dbo.Bills", "Balance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bills", "Balance", c => c.Double(nullable: false));
            DropColumn("dbo.Bills", "Payment");
        }
    }
}
