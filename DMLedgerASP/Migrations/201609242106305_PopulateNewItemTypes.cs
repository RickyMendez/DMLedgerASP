namespace DMLedgerASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNewItemTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO NewItemTypes (Id, ItemName) VALUES (1, 'Bank Account')");
            Sql("INSERT INTO NewItemTypes (Id, ItemName) VALUES (2, 'Bill')");
            Sql("INSERT INTO NewItemTypes (Id, ItemName) VALUES (3, 'Credit Card')");
        }
        
        public override void Down()
        {
        }
    }
}
