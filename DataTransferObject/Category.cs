using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Category
    {
        public int Id { get; set; }
        public string TenMuc { get; set; }

        public Category(int Id, String TenMuc) { 
            this.TenMuc = TenMuc;
            this.Id = Id;
        }
    }
}
