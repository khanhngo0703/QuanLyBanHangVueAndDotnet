using QuanLyBanHang.Common.BillDTO;
using QuanLyBanHang.Data;
using QuanLyBanHang.Models;

namespace QuanLyBanHang.Repository
{
    public interface IBillRepository : IBaseRepository<Bill>
    {
        Task<Bill> InsertFullDetailAsync(RequestBillFullDetail request);
    }
    public class BillRepository : BaseRepository<Bill>, IBillRepository
    {
        public BillRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }

        public async Task<Bill> InsertFullDetailAsync(RequestBillFullDetail request)
        {
            if (request != null)
            {
                if (request.Id == 0)
                {
                    var bill = new Bill()
                    {
                        Code = request.Code,
                        Date = request.Date,
                        PhoneNumber = request.PhoneNumber
                    };

                    _context.Bills.Add(bill);
                    await _context.SaveChangesAsync();

                    var billDetails = new List<BillDetail>();

                    if (bill.Id > 0)
                    {
                        foreach (var item in request.BillDetails)
                        {
                            item.Id = 0;
                            item.BillId = bill.Id;
                            var detailItem = new BillDetail()
                            {
                                BillId = item.BillId,
                                ProductId = item.ProductId,
                                Quantity = item.Quantity,
                                Price = item.Price
                            };
                            billDetails.Add(detailItem);
                        }
                        _context.BillDetails.AddRange(billDetails);
                        await _context.SaveChangesAsync();

                        return bill;
                    }
                }
            }
            return null;
        }
    }
}

