using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Chart
    {
        public string name {  get; set; }
        public decimal value { get; set; }
        public float soluong { get; set; }

        public Chart(string name, decimal value)
        {
            this.name = name;
            this.value = value;
        }

        public Chart(string name, float soluong)
        {
            this.name = name; this.soluong = soluong;
        }
    }
}
