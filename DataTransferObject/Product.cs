using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Product
    {
        public int Id { get; set; }
        public string tenSP { get; set; }
        public int loaiSP { get; set; }
        public float soLuongCon {  get; set; }
        public decimal giaBan { get; set; }
        public string donVi { get; set; }

        public byte[] imageBytes { get; set; }  

        public Product( string tenSP, int loaiSP, float soLuongCon, decimal giaBan, string donVi)
        {
            this.tenSP = tenSP;
            this.loaiSP = loaiSP;
            this.soLuongCon = soLuongCon;
            this.giaBan = giaBan;
            this.donVi = donVi;
        }

        public Product(string tenSP, int loaiSP, float soLuongCon, decimal giaBan, string donVi, byte[] imageBytes)
        {
            this.tenSP = tenSP;
            this.loaiSP = loaiSP;
            this.soLuongCon = soLuongCon;
            this.giaBan = giaBan;
            this.donVi = donVi;
            this.imageBytes = imageBytes;   
        }

        public Product(int id, string tenSP, int loaiSP, float soLuongCon, decimal giaBan, string donVi)
        {
            this.Id = id;
            this.tenSP = tenSP;
            this.loaiSP = loaiSP;
            this.soLuongCon = soLuongCon;
            this.giaBan = giaBan;
            this.donVi = donVi;
        }
    }
}
