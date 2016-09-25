namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveBankAccountDueDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BankAccounts", "DueDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BankAccounts", "DueDate", c => c.String());
        }
    }
}
