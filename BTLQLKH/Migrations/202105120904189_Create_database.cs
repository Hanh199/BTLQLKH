namespace BTLQLKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DSNKs",
                c => new
                    {
                        Sophieunhap = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaHDN = c.String(nullable: false, maxLength: 10),
                        MaKho = c.String(nullable: false, maxLength: 10),
                        TenMH = c.String(),
                        TenNCC = c.String(nullable: false),
                        Soluongnhap = c.Single(nullable: false),
                        Gianhap = c.Single(nullable: false),
                        Ngaynhap = c.String(),
                        Nhanviennhap = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Sophieunhap);
            
            CreateTable(
                "dbo.DSXKs",
                c => new
                    {
                        Sophieuxuat = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaHDX = c.String(nullable: false, maxLength: 10),
                        MaKho = c.String(nullable: false, maxLength: 10),
                        TenMH = c.String(),
                        TenKH = c.String(nullable: false),
                        Soluongban = c.Single(nullable: false),
                        Giaban = c.Single(nullable: false),
                        Ngayxuat = c.String(),
                        Nhanvienxuat = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Sophieuxuat);
            
            CreateTable(
                "dbo.HDNHAPs",
                c => new
                    {
                        MaHDN = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenHD = c.String(nullable: false, maxLength: 50),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        TenNCC = c.String(nullable: false),
                        Soluongnhap = c.Single(nullable: false),
                        Gianhap = c.Single(nullable: false),
                        Ngaynhap = c.String(),
                        Nhanviennhap = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaHDN);
            
            CreateTable(
                "dbo.HDXUATs",
                c => new
                    {
                        MaHDX = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenHDX = c.String(nullable: false, maxLength: 50),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        TenKH = c.String(nullable: false, maxLength: 10),
                        Soluongxuat = c.Single(nullable: false),
                        Giaban = c.Single(nullable: false),
                        Ngayxuat = c.String(),
                        Nhanvienxuat = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaHDX);
            
            CreateTable(
                "dbo.KHACHHANGs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenKH = c.String(nullable: false, maxLength: 50),
                        GioiTinh = c.String(),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        SĐT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.KHOHANGs",
                c => new
                    {
                        MaKho = c.String(nullable: false, maxLength: 10, unicode: false),
                        Tenkho = c.String(nullable: false, maxLength: 50),
                        SDT = c.Int(nullable: false),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        Thukho = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MaKho);
            
            CreateTable(
                "dbo.MATHANGs",
                c => new
                    {
                        MaMH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenMH = c.String(nullable: false, maxLength: 50),
                        SLton = c.Single(nullable: false),
                        DVT = c.String(),
                        Gianhap = c.String(),
                        MaNCC = c.String(nullable: false, maxLength: 10),
                        MaKho = c.String(nullable: false, maxLength: 10),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.MaMH);
            
            CreateTable(
                "dbo.NHACUNGCAPs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenNCC = c.String(nullable: false),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        SDT = c.String(),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenNV = c.String(nullable: false, maxLength: 50),
                        Vitrilamviec = c.String(),
                        GioiTinh = c.String(),
                        Diachi = c.String(nullable: false, maxLength: 100),
                        SĐT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NHANVIENs");
            DropTable("dbo.NHACUNGCAPs");
            DropTable("dbo.MATHANGs");
            DropTable("dbo.KHOHANGs");
            DropTable("dbo.KHACHHANGs");
            DropTable("dbo.HDXUATs");
            DropTable("dbo.HDNHAPs");
            DropTable("dbo.DSXKs");
            DropTable("dbo.DSNKs");
        }
    }
}
