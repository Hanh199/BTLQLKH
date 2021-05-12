namespace BTLQLKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_TRANGCHUs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            CreateTable(
                "dbo.TRANGCHUs",
                c => new
                    {
                        MaTT = c.String(nullable: false, maxLength: 128),
                        Noidung = c.String(),
                    })
                .PrimaryKey(t => t.MaTT);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TRANGCHUs");
            DropTable("dbo.Accounts");
        }
    }
}
