using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Sales_Reporting_Tool.DTOs
{
    public class SaleDto
    {

        public String ProductCode { get; set; } = string.Empty;
        public String ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total => Quantity * UnitPrice;
        public DateTime SaleDate { get; set; }


    }
}
