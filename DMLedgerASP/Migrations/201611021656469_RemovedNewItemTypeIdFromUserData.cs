namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNewItemTypeIdFromUserData : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DateTypeLists", "MonthlyModel_Id", "dbo.MonthlyModels");
            DropForeignKey("dbo.DateTypeLists", "YearlyModel_Id", "dbo.YearlyModels");
            DropForeignKey("dbo.DateTypeModels", "DateTypeList_Id", "dbo.DateTypeLists");
            DropIndex("dbo.DateTypeModels", new[] { "DateTypeList_Id" });
            DropIndex("dbo.DateTypeLists", new[] { "MonthlyModel_Id" });
            DropIndex("dbo.DateTypeLists", new[] { "YearlyModel_Id" });
            DropColumn("dbo.DateTypeModels", "DateTypeList_Id");
            DropTable("dbo.DateTypeLists");
            DropTable("dbo.MonthlyModels");
            DropTable("dbo.YearlyModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.YearlyModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        MonthDue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MonthlyModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DayOfMonthDue = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DateTypeLists",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        MonthlyModel_Id = c.Byte(),
                        YearlyModel_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DateTypeModels", "DateTypeList_Id", c => c.Byte());
            CreateIndex("dbo.DateTypeLists", "YearlyModel_Id");
            CreateIndex("dbo.DateTypeLists", "MonthlyModel_Id");
            CreateIndex("dbo.DateTypeModels", "DateTypeList_Id");
            AddForeignKey("dbo.DateTypeModels", "DateTypeList_Id", "dbo.DateTypeLists", "Id");
            AddForeignKey("dbo.DateTypeLists", "YearlyModel_Id", "dbo.YearlyModels", "Id");
            AddForeignKey("dbo.DateTypeLists", "MonthlyModel_Id", "dbo.MonthlyModels", "Id");
        }
    }
}
