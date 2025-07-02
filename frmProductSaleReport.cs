using DevExpress.XtraReports.UI;
using Product_Sales_Reporting_Tool.DTOs;
using Product_Sales_Reporting_Tool.Helpers;
using DevExpress.XtraPrinting;
using System.IO;

namespace Product_Sales_Reporting_Tool
{
    public partial class frmProductSaleReport : Form
    {
        public frmProductSaleReport()
        {
            InitializeComponent();
        }

        private List<SaleDto>? sales = new List<SaleDto>();
        private SaleReportXtraReport report = new SaleReportXtraReport();
        private string startDate = "", endDate = "";

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
            string filterName = filterProductName.Text.Trim();
            startDate = dateTimeStart.Value.ToString("yyyy-MM-dd");
            endDate = dateTimeEnd.Value.ToString("yyyy-MM-dd");

            report = new SaleReportXtraReport();
            sales = new List<SaleDto>();
            sales = DBOperation.QuerySaleBetweenDates(startDate, endDate, filterName);

            if (sales == null)
            {
                MessageBox.Show("Failed to query all reports!", "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (sales.Count > 0)
            {
                report.BindData(sales);
                report.PasteDate(startDate, endDate);

                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreview();

            }
            else
            {
                MessageBox.Show("There's no record were found!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (sales != null && sales.Count > 0)
            {
                string fileName = $"Sale Report_From_{startDate}_To_{endDate}.pdf";
                PdfExportOptions pdfOptions = report.ExportOptions.Pdf;
                pdfOptions.ConvertImagesToJpeg = false;
                pdfOptions.ImageQuality = PdfJpegImageQuality.Highest;
                pdfOptions.PdfACompatibility = PdfACompatibility.PdfA3b;
                pdfOptions.DocumentOptions.Title = fileName;

                IList<string> result = pdfOptions.Validate();
                if (result.Count > 0)
                {
                    MessageBox.Show(String.Join(Environment.NewLine, result),"Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                } else
                {
                    try
                    {
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = fileName;
                        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            fileName = saveFileDialog.FileName;
                            report.CreateDocument();
                            report.ExportToPdf(fileName, pdfOptions);

                            if (File.Exists(fileName))
                            {
                                MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Export failed: File was not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            } else
            {
                MessageBox.Show("Please Generate PDF first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
