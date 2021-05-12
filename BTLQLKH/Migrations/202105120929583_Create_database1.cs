namespace BTLQLKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DSNKs", "MATHANGs_MaMH", c => c.String(maxLength: 10, unicode: false));
            AddColumn("dbo.DSXKs", "MATHANGs_MaMH", c => c.String(maxLength: 10, unicode: false));
            AddColumn("dbo.HDNHAPs", "NHACUNGCAPs_MaNCC", c => c.String(maxLength: 10, unicode: false));
            AddColumn("dbo.HDNHAPs", "NHANVIENs_MaNV", c => c.String(maxLength: 10, unicode: false));
            AddColumn("dbo.HDXUATs", "KHACHHANGs_MaKH", c => c.String(maxLength: 10, unicode: false));
            AddColumn("dbo.HDXUATs", "NHANVIENs_MaNV", c => c.String(maxLength: 10, unicode: false));
            AlterColumn("dbo.DSNKs", "MaHDN", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.DSNKs", "MaKho", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.DSXKs", "MaHDX", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.DSXKs", "MaKho", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.MATHANGs", "MaKho", c => c.String(nullable: false, maxLength: 10, unicode: false));
            CreateIndex("dbo.DSNKs", "MaHDN");
            CreateIndex("dbo.DSNKs", "MaKho");
            CreateIndex("dbo.DSNKs", "MATHANGs_MaMH");
            CreateIndex("dbo.HDNHAPs", "NHACUNGCAPs_MaNCC");
            CreateIndex("dbo.HDNHAPs", "NHANVIENs_MaNV");
            CreateIndex("dbo.HDXUATs", "KHACHHANGs_MaKH");
            CreateIndex("dbo.HDXUATs", "NHANVIENs_MaNV");
            CreateIndex("dbo.DSXKs", "MaHDX");
            CreateIndex("dbo.DSXKs", "MaKho");
            CreateIndex("dbo.DSXKs", "MATHANGs_MaMH");
            CreateIndex("dbo.MATHANGs", "MaKho");
            AddForeignKey("dbo.DSNKs", "MaHDN", "dbo.HDNHAPs", "MaHDN", cascadeDelete: true);
            AddForeignKey("dbo.HDNHAPs", "NHACUNGCAPs_MaNCC", "dbo.NHACUNGCAPs", "MaNCC");
            AddForeignKey("dbo.HDNHAPs", "NHANVIENs_MaNV", "dbo.NHANVIENs", "MaNV");
            AddForeignKey("dbo.DSXKs", "MaHDX", "dbo.HDXUATs", "MaHDX", cascadeDelete: true);
            AddForeignKey("dbo.DSNKs", "MaKho", "dbo.KHOHANGs", "MaKho", cascadeDelete: true);
            AddForeignKey("dbo.DSXKs", "MaKho", "dbo.KHOHANGs", "MaKho", cascadeDelete: true);
            AddForeignKey("dbo.DSNKs", "MATHANGs_MaMH", "dbo.MATHANGs", "MaMH");
            AddForeignKey("dbo.DSXKs", "MATHANGs_MaMH", "dbo.MATHANGs", "MaMH");
            AddForeignKey("dbo.MATHANGs", "MaKho", "dbo.KHOHANGs", "MaKho", cascadeDelete: true);
            AddForeignKey("dbo.HDXUATs", "KHACHHANGs_MaKH", "dbo.KHACHHANGs", "MaKH");
            AddForeignKey("dbo.HDXUATs", "NHANVIENs_MaNV", "dbo.NHANVIENs", "MaNV");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HDXUATs", "NHANVIENs_MaNV", "dbo.NHANVIENs");
            DropForeignKey("dbo.HDXUATs", "KHACHHANGs_MaKH", "dbo.KHACHHANGs");
            DropForeignKey("dbo.MATHANGs", "MaKho", "dbo.KHOHANGs");
            DropForeignKey("dbo.DSXKs", "MATHANGs_MaMH", "dbo.MATHANGs");
            DropForeignKey("dbo.DSNKs", "MATHANGs_MaMH", "dbo.MATHANGs");
            DropForeignKey("dbo.DSXKs", "MaKho", "dbo.KHOHANGs");
            DropForeignKey("dbo.DSNKs", "MaKho", "dbo.KHOHANGs");
            DropForeignKey("dbo.DSXKs", "MaHDX", "dbo.HDXUATs");
            DropForeignKey("dbo.HDNHAPs", "NHANVIENs_MaNV", "dbo.NHANVIENs");
            DropForeignKey("dbo.HDNHAPs", "NHACUNGCAPs_MaNCC", "dbo.NHACUNGCAPs");
            DropForeignKey("dbo.DSNKs", "MaHDN", "dbo.HDNHAPs");
            DropIndex("dbo.MATHANGs", new[] { "MaKho" });
            DropIndex("dbo.DSXKs", new[] { "MATHANGs_MaMH" });
            DropIndex("dbo.DSXKs", new[] { "MaKho" });
            DropIndex("dbo.DSXKs", new[] { "MaHDX" });
            DropIndex("dbo.HDXUATs", new[] { "NHANVIENs_MaNV" });
            DropIndex("dbo.HDXUATs", new[] { "KHACHHANGs_MaKH" });
            DropIndex("dbo.HDNHAPs", new[] { "NHANVIENs_MaNV" });
            DropIndex("dbo.HDNHAPs", new[] { "NHACUNGCAPs_MaNCC" });
            DropIndex("dbo.DSNKs", new[] { "MATHANGs_MaMH" });
            DropIndex("dbo.DSNKs", new[] { "MaKho" });
            DropIndex("dbo.DSNKs", new[] { "MaHDN" });
            AlterColumn("dbo.MATHANGs", "MaKho", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DSXKs", "MaKho", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DSXKs", "MaHDX", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DSNKs", "MaKho", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.DSNKs", "MaHDN", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.HDXUATs", "NHANVIENs_MaNV");
            DropColumn("dbo.HDXUATs", "KHACHHANGs_MaKH");
            DropColumn("dbo.HDNHAPs", "NHANVIENs_MaNV");
            DropColumn("dbo.HDNHAPs", "NHACUNGCAPs_MaNCC");
            DropColumn("dbo.DSXKs", "MATHANGs_MaMH");
            DropColumn("dbo.DSNKs", "MATHANGs_MaMH");
        }
    }
}
