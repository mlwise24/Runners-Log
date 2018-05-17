namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeVariable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RunInputs", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RunInputs", "Time", c => c.DateTime());
        }
    }
}
