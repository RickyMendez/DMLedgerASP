namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentToCreditCards : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CreditCards", "Payment", c => c.Single(nullable: false));
            AlterColumn("dbo.CreditCards", "Limit", c => c.Single(nullable: false));
            AlterColumn("dbo.CreditCards", "Balance", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CreditCards", "Balance", c => c.Double(nullable: false));
            AlterColumn("dbo.CreditCards", "Limit", c => c.Double(nullable: false));
            DropColumn("dbo.CreditCards", "Payment");
        }
    }
}
