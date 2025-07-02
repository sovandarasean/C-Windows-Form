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

        public void PasteDate(string startDate, string endDate)
        {
            labelDate.Text = $"From: {startDate} To: {endDate}";
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

            bool isFirst = true;

            foreach (var group in groupedSales)
            {
                
                XRTableRow headerRow = new XRTableRow();

                if (isFirst)
                {
                    XRTableRow headerRow1 = reportTable.Rows[0];
                    headerRow1.Cells.Clear();

                    XRTableCell productHeader1 = new XRTableCell
                    {
                        Text = $"Product: {group.Key.ProductName} - {group.Key.ProductCode}",
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft,
                        Font = new Font("Noto Sans Khmer", 10, FontStyle.Bold),
                        Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 20, 5),
                        Borders = DevExpress.XtraPrinting.BorderSide.Bottom,
                        BorderWidth = 1,
                        Weight = 3.0
                    };

                    headerRow1.Cells.Add(productHeader1);
                    isFirst = false;
                } else
                {
                    XRTableCell productHeader = new XRTableCell
                    {
                        Text = $"Product: {group.Key.ProductName} - {group.Key.ProductCode}",
                        TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft,
                        Font = new Font("Noto Sans Khmer", 10, FontStyle.Bold),
                        Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 20, 5),
                        Borders = DevExpress.XtraPrinting.BorderSide.Bottom,
                        BorderWidth = 1,

                    };
                    headerRow.Cells.Add(productHeader);
                    reportTable.Rows.Add(headerRow);
                }

                headerRow = new XRTableRow();
                AddCellHeader("Product Name", headerRow);
                AddCellHeader("Quantity", headerRow);
                AddCellHeader("Total", headerRow);

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
                AddGroupCellSummary(group, "Group Summary:", summaryRow);
                AddGroupCellSummary(group, group.Sum(x => x.Quantity).ToString(), summaryRow);
                AddGroupCellSummary(group, group.Sum(x => x.Total).ToString("F2"), summaryRow);

                reportTable.Rows.Add(summaryRow);
            }

            //grand total row
            int totalQuantity = sales.Sum(s => s.Quantity);
            decimal totalRevenue = sales.Sum(s => s.Total);
            XRTableRow grandTotalRow = grandTotalTable.Rows[0];
            XRTableCell quantityCell = grandTotalRow.Cells[1];
            XRTableCell grandTotalCell = grandTotalRow.Cells[2];

            quantityCell.Text = totalQuantity.ToString();
            grandTotalCell.Text = totalRevenue.ToString("F2");
        }

        private void AddCellHeader(string text, XRTableRow headerRow)
        {
            XRTableCell cellHeader = new XRTableCell
            {
                Text = text,
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                Font = new Font("Noto Sans Khmer", 10, FontStyle.Bold),
                Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0),
                Borders = DevExpress.XtraPrinting.BorderSide.All,
                BorderWidth = 1,

            };
            headerRow.Cells.Add(cellHeader);
        }

        private void AddGroupCellSummary(IGrouping<object, SaleDto> group, string text, XRTableRow summaryRow)
        {
            XRTableCell tableCell = new XRTableCell
            {
                Text = text,
                TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                Font = new Font("Noto Sans Khmer", 10, FontStyle.Bold),
                Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 0),
                Borders = DevExpress.XtraPrinting.BorderSide.None
            };

            summaryRow.Cells.Add(tableCell);
        }
    }
}
