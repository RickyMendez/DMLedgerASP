namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBillsDbSet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Balance = c.Double(nullable: false),
                        DueDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bills");
        }
    }
}
