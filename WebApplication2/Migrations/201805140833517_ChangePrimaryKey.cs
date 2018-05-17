namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePrimaryKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RunInputs");
            AddColumn("dbo.RunInputs", "Date", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.RunInputs", "Date");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RunInputs");
            DropColumn("dbo.RunInputs", "Date");
            AddPrimaryKey("dbo.RunInputs", "Time");
        }
    }
}
