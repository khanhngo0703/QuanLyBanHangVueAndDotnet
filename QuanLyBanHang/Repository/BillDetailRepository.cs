using QuanLyBanHang.Data;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Repository
{
    public interface IBillDetailRepository : IBaseRepository<BillDetail>
    {

    }
    public class BillDetailRepository : BaseRepository<BillDetail>, IBillDetailRepository
    {
        public BillDetailRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}