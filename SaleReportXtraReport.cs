using DevExpress.XtraReports.UI;
using Product_Sales_Reporting_Tool.DTOs;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Product_Sales_Reporting_Tool
{
    public partial class SaleReportXtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SaleReportXtraReport()
        {
            InitializeComponent();
        }

        public void BindData(List<SaleDto> sales)
        {
            // Clear table (except header)
            while (reportTable.Rows.Count > 1)
            {
                reportTable.Rows.RemoveAt(1);
            }

            // Group sales by ProductCode
            var groupedSales = sales
                .GroupBy(s => new { s.ProductCode, s.ProductName })
                .ToList();

            foreach (var group in groupedSales)
            {
                
                XRTableRow headerRow = new XRTableRow();
                XRTableCell productHeader = new XRTableCell
                {
                    Text = $"Product: {group.Key.ProductName} - {group.Key.ProductCode}",
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft,
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 20, 5),
                    Borders = DevExpress.XtraPrinting.BorderSide.Bottom,
                    BorderWidth = 1,
                   
                };
                headerRow.Cells.Add(productHeader);
                reportTable.Rows.Add(headerRow);

                headerRow = new XRTableRow();
                XRTableCell productNameHeader = new XRTableCell
                {
                    Text = "Product Name",
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0),
                    Borders = DevExpress.XtraPrinting.BorderSide.All,
                    BorderWidth = 1,

                };

                XRTableCell quantityHeader = new XRTableCell
                {
                    Text = "Quantity",
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0),
                    Borders = DevExpress.XtraPrinting.BorderSide.All,
                    BorderWidth = 1,

                };

                XRTableCell totalHeader = new XRTableCell
                {
                    Text = "Total",
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0),
                    Borders = DevExpress.XtraPrinting.BorderSide.All,
                    BorderWidth = 1,

                };

                headerRow.Cells.AddRange(new[] {productNameHeader, quantityHeader, totalHeader});
                reportTable.Rows.Add(headerRow);

                // Add data rows
                foreach (var sale in group)
                {
                    XRTableRow row = new XRTableRow();

                    XRTableCell cellProductName = new XRTableCell { Text = sale.ProductName };
                    XRTableCell cellQuantity = new XRTableCell { Text = sale.Quantity.ToString() };
                    XRTableCell cellTotal = new XRTableCell { Text = sale.Total.ToString("F2") };

                    cellProductName.Padding = cellQuantity.Padding = cellTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0);
                    cellProductName.Borders = cellQuantity.Borders = cellTotal.Borders = DevExpress.XtraPrinting.BorderSide.All;

                    row.Cells.AddRange(new[] { cellProductName, cellQuantity, cellTotal });
                    reportTable.Rows.Add(row);
                }

                // Add summary row for group
                XRTableRow summaryRow = new XRTableRow();

                XRTableCell summaryLabel = new XRTableCell
                {
                    Text = "Group Summary:",
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0),
                    Borders = DevExpress.XtraPrinting.BorderSide.None
                };

                XRTableCell totalQty = new XRTableCell
                {
                    Text = group.Sum(x => x.Quantity).ToString(),
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0),
                    Borders = DevExpress.XtraPrinting.BorderSide.None
                };

                XRTableCell totalAmount = new XRTableCell
                {
                    Text = group.Sum(x => x.Total).ToString("F2"),
                    Font = new Font("Calibri", 10, FontStyle.Bold),
                    Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0),
                    Borders = DevExpress.XtraPrinting.BorderSide.None
                };

                summaryRow.Cells.AddRange(new[] { summaryLabel, totalQty, totalAmount });
                reportTable.Rows.Add(summaryRow);
            }

            //grand total row
            int totalQuantity = sales.Sum(s => s.Quantity);
            decimal totalRevenue = sales.Sum(s => s.Total);
            XRTableRow grandTotalRow = new XRTableRow();

            XRTableCell labelCell = new XRTableCell
            {
                Text = "Grand Total:",
                Font = new Font("Calibri", 10, FontStyle.Bold),
                Borders = DevExpress.XtraPrinting.BorderSide.Top,
                Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 30, 0),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft,
            };

            XRTableCell quantityTotalCell = new XRTableCell
            {
                Text = totalQuantity.ToString(),
                Font = new Font("Calibri", 10, FontStyle.Bold),
                Borders = DevExpress.XtraPrinting.BorderSide.Top,
                Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 30, 0),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            };

            XRTableCell revenueTotalCell = new XRTableCell
            {
                Text = totalRevenue.ToString("F2"),
                Font = new Font("Calibri", 10, FontStyle.Bold),
                Borders = DevExpress.XtraPrinting.BorderSide.Top,
                Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 30, 0),
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            };

            grandTotalRow.Cells.AddRange(new[] { labelCell, quantityTotalCell, revenueTotalCell });
            reportTable.Rows.Add(grandTotalRow);
        }
    }
}
