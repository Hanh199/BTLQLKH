using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTLQLKH.Models
{
    public partial class BTLQLKHDbContext : DbContext
    {
        public BTLQLKHDbContext()
            : base("name=BTLQLKHDbContext")
        {
        }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHOHANG> KHOHANGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<HDNHAP> HDNHAPs { get; set; }
        public virtual DbSet<HDXUAT> HDXUATs { get; set; }
        public virtual DbSet<DSNK> DSNKs { get; set; }
        public virtual DbSet<DSXK> DSXKs { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<TRANGCHU> TRANGCHUs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MATHANG>()
               .Property(e => e.MaMH)
              .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
               .Property(e => e.MaKH)
              .IsUnicode(false);

            modelBuilder.Entity<KHOHANG>()
               .Property(e => e.MaKho)
              .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
               .Property(e => e.MaNCC)
              .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
               .Property(e => e.MaNV)
              .IsUnicode(false);

            modelBuilder.Entity<HDXUAT>()
               .Property(e => e.MaHDX)
              .IsUnicode(false);

            modelBuilder.Entity<HDNHAP>()
               .Property(e => e.MaHDN)
              .IsUnicode(false);

            modelBuilder.Entity<DSNK>()
               .Property(e => e.Sophieunhap)
              .IsUnicode(false);

            modelBuilder.Entity<DSXK>()
               .Property(e => e.Sophieuxuat)
              .IsUnicode(false);
        }
    }
}
