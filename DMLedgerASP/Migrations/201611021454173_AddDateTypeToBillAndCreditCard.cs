namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTypeToBillAndCreditCard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateTypeModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DateType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bills", "DateTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Bills", "DateTypeModel_Id", c => c.Byte());
            AddColumn("dbo.CreditCards", "DateTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.CreditCards", "DateTypeModel_Id", c => c.Byte());
            CreateIndex("dbo.Bills", "DateTypeModel_Id");
            CreateIndex("dbo.CreditCards", "DateTypeModel_Id");
            AddForeignKey("dbo.Bills", "DateTypeModel_Id", "dbo.DateTypeModels", "Id");
            AddForeignKey("dbo.CreditCards", "DateTypeModel_Id", "dbo.DateTypeModels", "Id");
            DropColumn("dbo.Bills", "DueDate");
            DropColumn("dbo.Bills", "NewItemTypeId");
            DropColumn("dbo.CreditCards", "NewItemTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CreditCards", "NewItemTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Bills", "NewItemTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Bills", "DueDate", c => c.String());
            DropForeignKey("dbo.CreditCards", "DateTypeModel_Id", "dbo.DateTypeModels");
            DropForeignKey("dbo.Bills", "DateTypeModel_Id", "dbo.DateTypeModels");
            DropIndex("dbo.CreditCards", new[] { "DateTypeModel_Id" });
            DropIndex("dbo.Bills", new[] { "DateTypeModel_Id" });
            DropColumn("dbo.CreditCards", "DateTypeModel_Id");
            DropColumn("dbo.CreditCards", "DateTypeId");
            DropColumn("dbo.Bills", "DateTypeModel_Id");
            DropColumn("dbo.Bills", "DateTypeId");
            DropTable("dbo.DateTypeModels");
        }
    }
}
