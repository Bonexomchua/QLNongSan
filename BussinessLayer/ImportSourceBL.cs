using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class ImportSourceBL
    {
        ImportSourceDL ipDL = new ImportSourceDL();
        public List<ImportSource> GetAllImportSource()
        {
            return ipDL.GetAllImportSource();
        }

        public void AddImportSource(String HoVaTen, String TenCongTy, String DiaChi, String SoDienThoai, String tenSP)
        {
            ProductDL prodDL = new ProductDL();
            int prodId = prodDL.GetProductIdByName(tenSP);

            ImportSource ip = new ImportSource(HoVaTen,TenCongTy, DiaChi, SoDienThoai,prodId);

            ipDL.AddImportSource(ip);
        }

        public int CheckImportSourceExistByPhone(String Phone)
        {
            return ipDL.CheckImportSourceExistByPhone(Phone);
        }

        public void DeleteImportSourceByPhone(String Phone)
        {
            ipDL.DeleteImportSourceByPhone(Phone);
        }

        public void UpdateImportSource(string ten,string congty,string sdt, string diachi, int id)
        {
            ipDL.UpdateImportSource(ten,congty,sdt,diachi,id);
        }

        public int GetImportSourceIdByPhone(String Phone)
        {
            return ipDL.GetIPIdByPhone(Phone);
        }
    }
}
