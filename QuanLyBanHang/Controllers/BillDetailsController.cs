using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Models;
using QuanLyBanHang.Repository;
namespace QuanLyBanHang.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillDetailsController : BaseController<BillDetail>
    {
        public BillDetailsController(IBaseRepository<BillDetail> repository) : base(repository)
        {
        }
    }
}