namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedItemTypeFromBankAccount : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BankAccounts", "NewItemTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BankAccounts", "NewItemTypeId", c => c.Byte(nullable: false));
        }
    }
}
