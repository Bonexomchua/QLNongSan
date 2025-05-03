using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Bill
    {
        public int id {  get; set; }
        public int loaiHoaDon {  get; set; }
        public decimal tongTien { get; set; }
        public DateTime ngayThanhToan {  get; set; }
        public int customerId { get; set; }
        public int userId { get; set; }
        public int importId { get; set; }
        
        public List<int> productId { get; set; }

        public Bill(int loaiHoaDon, decimal tongTien, DateTime ngayThanhToan, int customerId, int userId, List<int> productId)
        {
            this.loaiHoaDon = loaiHoaDon;
            this.tongTien = tongTien;
            this.ngayThanhToan = ngayThanhToan;
            this.customerId = customerId;
            this.userId = userId;
            this.productId = productId;
        }
        public Bill(int id,int loaiHoaDon, decimal tongTien, DateTime ngayThanhToan, int customerId, int userId, List<int> productId)
        {
            this.id = id;
            this.loaiHoaDon = loaiHoaDon;
            this.tongTien = tongTien;
            this.ngayThanhToan = ngayThanhToan;
            this.customerId = customerId;
            this.userId = userId;
            this.productId = productId;
        }

        /*        public Bill(int loaiHoaDon, decimal tongTien, DateTime ngayThanhToan, int userId, int importId, List<int> productId)
                {
                    this.loaiHoaDon = loaiHoaDon;
                    this.tongTien = tongTien;
                    this.ngayThanhToan = ngayThanhToan;
                    this.importId = importId;
                    this.userId = userId;
                    this.productId = productId;
                }*/
    }
}
