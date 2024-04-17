using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.SeedData();
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }        
        public virtual DbSet<BillDetail> BillDetails { get; set; }


        private async void SeedData()
        {
            if (this.Products.Count() <= 0)
            {
                var p1 = new Product() { ProductName = "Dui ga", Price = 15000, ImageProduct = null, BarCode = "12412342" };
                var p2 = new Product() { ProductName = "Ca vien", Price = 16500, ImageProduct = null, BarCode = "4635342" };
                var p3 = new Product() { ProductName = "Tom chien", Price = 25000, ImageProduct = null, BarCode = "185673362" };
                var p4 = new Product() { ProductName = "Nem chua ran", Price = 11000, ImageProduct = null, BarCode = "74874564" };
                var p5 = new Product() { ProductName = "Muc kho", Price = 5000, ImageProduct = null, BarCode = "135365776" };
                

                this.Products.Add(p1);
                this.Products.Add(p2);
                this.Products.Add(p3);
                this.Products.Add(p4);
                this.Products.Add(p5);
                

                this.SaveChanges();
            }

                   
        }
    }
}