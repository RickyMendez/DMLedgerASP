namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBankAccountDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Balance = c.Double(nullable: false),
                        DueDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BankAccounts");
        }
    }
}
