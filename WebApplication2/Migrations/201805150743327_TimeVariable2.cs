namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeVariable2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RunInputs", "Time", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RunInputs", "Time");
        }
    }
}
