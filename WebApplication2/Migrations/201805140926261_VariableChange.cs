namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VariableChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RunInputs", "Time", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RunInputs", "Time", c => c.DateTime(nullable: false));
        }
    }
}
