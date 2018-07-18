namespace FoodieGroupies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        RestaurantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantID, cascadeDelete: true)
                .Index(t => t.RestaurantID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RestaurantID", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "RestaurantID" });
            DropTable("dbo.Reviews");
        }
    }
}
