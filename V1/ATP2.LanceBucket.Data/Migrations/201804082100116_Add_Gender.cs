namespace ATP2.LanceBucket.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Gender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserInfoes", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserInfoes", "Gender");
        }
    }
}
