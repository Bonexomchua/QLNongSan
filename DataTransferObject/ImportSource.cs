using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ImportSource
    {
        public String HoVaTen { get; set; }
        public String TenCongTy { get; set; }
        public String DiaChi { get; set; }
        public String SoDienThoai { get; set;}
        public int ProductId { get; set; }

        public ImportSource( String HoVaTen, String TenCongTy, String DiaChi, String SoDienThoai,int ProdId)
        {
            this.HoVaTen = HoVaTen;
            this.TenCongTy = TenCongTy;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.ProductId = ProdId;
        }

        public ImportSource( String HoVaTen, String DiaChi, String SoDienThoai)
        {
            this.HoVaTen= HoVaTen;
            this.DiaChi= DiaChi;
            this.SoDienThoai= SoDienThoai;
        }
    }
}
