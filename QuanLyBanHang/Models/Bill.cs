using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models
{
    public class Bill : Base
    {
        public string? Code { get; set; }
        public DateTime? Date { get; set; }
        public string? PhoneNumber { get; set; }
        // public virtual ICollection<BillDetail>? BillDetails { get; set; }
    }
}
