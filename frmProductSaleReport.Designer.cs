namespace Product_Sales_Reporting_Tool
{
    partial class frmProductSaleReport
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimeStart = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimeEnd = new DateTimePicker();
            btnGenerateReport = new Button();
            label3 = new Label();
            btnExportPdf = new Button();
            filterProductName = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(97, 34);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(250, 27);
            dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F);
            label1.Location = new Point(10, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 1;
            label1.Text = "Start Date:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10F);
            label2.Location = new Point(10, 70);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "End Date:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(97, 67);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(250, 27);
            dateTimeEnd.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(236, 266);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(209, 40);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(183, 24);
            label3.Name = "label3";
            label3.Size = new Size(315, 37);
            label3.TabIndex = 5;
            label3.Text = "Product Sales Reporting";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExportPdf.Location = new Point(236, 312);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(209, 40);
            btnExportPdf.TabIndex = 6;
            btnExportPdf.Text = "Export as PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // filterProductName
            // 
            filterProductName.Location = new Point(226, 105);
            filterProductName.Name = "filterProductName";
            filterProductName.PlaceholderText = "Enter product's name/keep it blank";
            filterProductName.Size = new Size(250, 27);
            filterProductName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10F);
            label4.Location = new Point(139, 109);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 1;
            label4.Text = "Filter:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimeStart);
            groupBox1.Controls.Add(dateTimeEnd);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(139, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 110);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Date";
            // 
            // frmProductSaleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 419);
            Controls.Add(groupBox1);
            Controls.Add(filterProductName);
            Controls.Add(btnExportPdf);
            Controls.Add(label3);
            Controls.Add(btnGenerateReport);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmProductSaleReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Sales Reporting Tool";
            Load += frmProductSaleReport_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeStart;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimeEnd;
        private Button btnGenerateReport;
        private Label label3;
        private Button btnExportPdf;
        private TextBox filterProductName;
        private Label label4;
        private GroupBox groupBox1;
    }
}
