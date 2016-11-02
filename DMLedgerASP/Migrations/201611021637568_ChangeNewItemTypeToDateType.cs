namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNewItemTypeToDateType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DateTypeLists",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        MonthlyModel_Id = c.Byte(),
                        YearlyModel_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MonthlyModels", t => t.MonthlyModel_Id)
                .ForeignKey("dbo.YearlyModels", t => t.YearlyModel_Id)
                .Index(t => t.MonthlyModel_Id)
                .Index(t => t.YearlyModel_Id);
            
            CreateTable(
                "dbo.MonthlyModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        DayOfMonthDue = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.YearlyModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        MonthDue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DateTypeModels", "DateTypeList_Id", c => c.Byte());
            CreateIndex("dbo.DateTypeModels", "DateTypeList_Id");
            AddForeignKey("dbo.DateTypeModels", "DateTypeList_Id", "dbo.DateTypeLists", "Id");
            DropColumn("dbo.DateTypeModels", "DateType");
            DropTable("dbo.NewItemTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NewItemTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        ItemName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DateTypeModels", "DateType", c => c.String());
            DropForeignKey("dbo.DateTypeModels", "DateTypeList_Id", "dbo.DateTypeLists");
            DropForeignKey("dbo.DateTypeLists", "YearlyModel_Id", "dbo.YearlyModels");
            DropForeignKey("dbo.DateTypeLists", "MonthlyModel_Id", "dbo.MonthlyModels");
            DropIndex("dbo.DateTypeLists", new[] { "YearlyModel_Id" });
            DropIndex("dbo.DateTypeLists", new[] { "MonthlyModel_Id" });
            DropIndex("dbo.DateTypeModels", new[] { "DateTypeList_Id" });
            DropColumn("dbo.DateTypeModels", "DateTypeList_Id");
            DropTable("dbo.YearlyModels");
            DropTable("dbo.MonthlyModels");
            DropTable("dbo.DateTypeLists");
        }
    }
}
