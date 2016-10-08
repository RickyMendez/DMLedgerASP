namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewItemTypeToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BankAccounts", "NewItemTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Bills", "NewItemTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.CreditCards", "NewItemTypeId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CreditCards", "NewItemTypeId");
            DropColumn("dbo.Bills", "NewItemTypeId");
            DropColumn("dbo.BankAccounts", "NewItemTypeId");
        }
    }
}
