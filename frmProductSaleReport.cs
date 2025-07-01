using DevExpress.XtraReports.UI;
using Product_Sales_Reporting_Tool.DTOs;
using Product_Sales_Reporting_Tool.Helpers;

namespace Product_Sales_Reporting_Tool
{
    public partial class frmProductSaleReport : Form
    {
        public frmProductSaleReport()
        {
            InitializeComponent();
        }

        private void frmProductSaleReport_Load(object sender, EventArgs e)
        {
            //attempt connect to local database
            if (!DBOperation.ConnectDB())
            {
                MessageBox.Show("Connection Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string startDate = dateTimeStart.Value.ToString("yyyy-MM-dd");
            string endDate = dateTimeEnd.Value.ToString("yyyy-MM-dd");
            var sales = new List<SaleDto>();

            sales = DBOperation.QuerySaleBetweenDates(startDate, endDate);

            SaleReportXtraReport report = new SaleReportXtraReport();
            report.BindData(sales);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();

        }
    }
}
