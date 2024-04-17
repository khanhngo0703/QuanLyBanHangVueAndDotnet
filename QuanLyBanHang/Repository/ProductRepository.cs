using QuanLyBanHang.Data;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {

    }
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
