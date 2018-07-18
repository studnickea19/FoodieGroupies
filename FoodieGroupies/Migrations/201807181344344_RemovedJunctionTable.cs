namespace FoodieGroupies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedJunctionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "CuisineID", c => c.Int(nullable: false));
            CreateIndex("dbo.Restaurants", "CuisineID");
            AddForeignKey("dbo.Restaurants", "CuisineID", "dbo.Cuisines", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurants", "CuisineID", "dbo.Cuisines");
            DropIndex("dbo.Restaurants", new[] { "CuisineID" });
            DropColumn("dbo.Restaurants", "CuisineID");
        }
    }
}
