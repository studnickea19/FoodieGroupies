namespace FoodieGroupies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJunctionTableRandC : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Restaurants", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "Type", c => c.String(maxLength: 50));
        }
    }
}
