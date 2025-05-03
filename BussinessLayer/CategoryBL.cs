using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class CategoryBL
    {
        CategoryDL cateDL = new CategoryDL();
        public int GetCateIdByName(string name)
        {
            return cateDL.GetCateIdByName(name);
        }

        public string GetCateNameById(int id)
        {
            return cateDL.GetCateNameById(id);
        }

        public DataTable GetCateTable()
        {
            return cateDL.GetCateTable();
        }

        public void UpdateDataTable(DataTable dt)
        {
            cateDL.UpdateCateTable(dt);
        }


    }
}
