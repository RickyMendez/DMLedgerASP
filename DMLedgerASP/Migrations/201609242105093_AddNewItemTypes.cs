namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewItemTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewItemTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        ItemName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewItemTypes");
        }
    }
}
