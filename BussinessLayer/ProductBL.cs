using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class ProductBL
    {

        LoadDataBL loadDataBL = new LoadDataBL();
        ProductDL productDL = new ProductDL();
        public void AddProduct(String tenSanPham, String loai, float soLuong, String donVi, decimal donGia, decimal giaLai, byte[] imageBytes)
        {
            decimal giaBan = donGia + giaLai;
            int cateId = loadDataBL.GetCateIdByName(loai);
            Product prod = new Product(tenSanPham,cateId,soLuong,giaBan,donVi,imageBytes);
            productDL.addProduct(prod);
          
        }

        public List<Product> GetAllProduct()
        {
            return productDL.GetAllProduct();
        }

        public void DeleteProductByName(String name)
        {
            productDL.DeleteProductByName(name);
        }

        public Product GetProductByName(String name)
        {
            return productDL.GetProductByName(name);
        }

        public void UpdateProduct(int id, Product prod)
        {
            productDL.UpdateProductById(id, prod);
        }

        public int GetProductIdByName(String name)
        {
           return productDL.GetProductIdByName(name);
        }
        public int GetMaxIdByName(String name)
        {
            return productDL.GetMaxIdByName(name);
        }

        public List<Product> GetProductByKW(String kw)
        {
            return productDL.GetProductByKW(kw);
        }

        public void UpdateAmount(float newSL, int id)
        {
            productDL.UpdateAmount(newSL, id);
        }

        public void AddAmount(float newSL, int id)
        {
            productDL.AddAdmout(newSL, id);
        }

        public string GetProductNameById(int id)
        {
            return productDL.GetProductNameById(id);
        }
    }
}
