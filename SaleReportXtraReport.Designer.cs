namespace Product_Sales_Reporting_Tool
{
    partial class SaleReportXtraReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.labelDate = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.grandTotalTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.grandTotalText = new DevExpress.XtraReports.UI.XRTableCell();
            this.quantityCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.grandTotalCell = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.reportTable = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grandTotalTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.labelDate});
            this.TopMargin.HeightF = 40.47619F;
            this.TopMargin.Name = "TopMargin";
            // 
            // labelDate
            // 
            this.labelDate.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 8.5F);
            this.labelDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.4762F);
            this.labelDate.Multiline = true;
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelDate.SizeF = new System.Drawing.SizeF(256.5675F, 22.99999F);
            this.labelDate.StylePriority.UseFont = false;
            this.labelDate.StylePriority.UseTextAlignment = false;
            this.labelDate.Text = "From: 2025-06-11 To: 2025-06-20";
            this.labelDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 98.65383F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.grandTotalTable,
            this.xrLine1,
            this.reportTable,
            this.xrLabel1});
            this.Detail.Font = new DevExpress.Drawing.DXFont("Calibri", 9.75F);
            this.Detail.HeightF = 697.6191F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            this.xrLine2.LineWidth = 2F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(88.5715F, 139.7142F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(503.988F, 23F);
            // 
            // grandTotalTable
            // 
            this.grandTotalTable.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.grandTotalTable.BorderWidth = 1F;
            this.grandTotalTable.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 10F);
            this.grandTotalTable.LocationFloat = new DevExpress.Utils.PointFloat(88.5715F, 162.7142F);
            this.grandTotalTable.Name = "grandTotalTable";
            this.grandTotalTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.grandTotalTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.grandTotalTable.SizeF = new System.Drawing.SizeF(503.9881F, 25F);
            this.grandTotalTable.StylePriority.UseBorders = false;
            this.grandTotalTable.StylePriority.UseBorderWidth = false;
            this.grandTotalTable.StylePriority.UseFont = false;
            this.grandTotalTable.StylePriority.UseTextAlignment = false;
            this.grandTotalTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.grandTotalText,
            this.quantityCell,
            this.grandTotalCell});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // grandTotalText
            // 
            this.grandTotalText.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.grandTotalText.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.grandTotalText.Multiline = true;
            this.grandTotalText.Name = "grandTotalText";
            this.grandTotalText.StylePriority.UseBorders = false;
            this.grandTotalText.StylePriority.UseFont = false;
            this.grandTotalText.StylePriority.UseTextAlignment = false;
            this.grandTotalText.Text = "Grand Total:";
            this.grandTotalText.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.grandTotalText.Weight = 1.1266799555841425D;
            // 
            // quantityCell
            // 
            this.quantityCell.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.quantityCell.Multiline = true;
            this.quantityCell.Name = "quantityCell";
            this.quantityCell.StylePriority.UseFont = false;
            this.quantityCell.Weight = 1.1266799555841425D;
            // 
            // grandTotalCell
            // 
            this.grandTotalCell.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.grandTotalCell.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.grandTotalCell.Multiline = true;
            this.grandTotalCell.Name = "grandTotalCell";
            this.grandTotalCell.StylePriority.UseBorders = false;
            this.grandTotalCell.StylePriority.UseFont = false;
            this.grandTotalCell.Weight = 1.1266799555841425D;
            // 
            // xrLine1
            // 
            this.xrLine1.LineWidth = 5F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(23.19444F, 75.0476F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(602.9166F, 22.99999F);
            // 
            // reportTable
            // 
            this.reportTable.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.reportTable.BorderWidth = 1F;
            this.reportTable.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 10F);
            this.reportTable.LocationFloat = new DevExpress.Utils.PointFloat(88.5715F, 98.04758F);
            this.reportTable.Name = "reportTable";
            this.reportTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.reportTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.reportTable.SizeF = new System.Drawing.SizeF(503.9881F, 25F);
            this.reportTable.StylePriority.UseBorders = false;
            this.reportTable.StylePriority.UseBorderWidth = false;
            this.reportTable.StylePriority.UseFont = false;
            this.reportTable.StylePriority.UseTextAlignment = false;
            this.reportTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Font = new DevExpress.Drawing.DXFont("Calibri", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.Weight = 1.1266799555841425D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new DevExpress.Drawing.DXFont("Calibri", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.Weight = 1.1266799555841425D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Font = new DevExpress.Drawing.DXFont("Calibri", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Weight = 1.1266799555841425D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Noto Sans Khmer", 17F, ((DevExpress.Drawing.DXFontStyle)((DevExpress.Drawing.DXFontStyle.Bold | DevExpress.Drawing.DXFontStyle.Underline))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(230.516F, 10F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(194.0476F, 42.04762F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Sales Report";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SaleReportXtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 40.47619F, 98.65383F);
            this.Version = "24.2";
            ((System.ComponentModel.ISupportInitialize)(this.grandTotalTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel labelDate;
        private DevExpress.XtraReports.UI.XRTable reportTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRTable grandTotalTable;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell grandTotalText;
        private DevExpress.XtraReports.UI.XRTableCell quantityCell;
        private DevExpress.XtraReports.UI.XRTableCell grandTotalCell;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
    }
}
