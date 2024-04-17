using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Models;
using QuanLyBanHang.Repository;

namespace QuanLyBanHang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController<Product>
    {
        public ProductsController(IBaseRepository<Product> repository) : base(repository)
        {
        }
    }
}
