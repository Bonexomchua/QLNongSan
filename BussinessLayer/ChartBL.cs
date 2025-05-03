using DataLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class ChartBL
    {
        private ChartDL chartDL = new ChartDL();
        public List<Chart> GetBillByThang()
        {
            return chartDL.BillChartByMonth();
        }

        public List<Chart> GetBillByProduct() 
        {
            return chartDL.BillChartByProduct();
        }
    }
}
