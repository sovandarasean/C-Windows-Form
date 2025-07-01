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
            SuspendLayout();
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(226, 114);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(250, 27);
            dateTimeStart.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F);
            label1.Location = new Point(139, 117);
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
            label2.Location = new Point(139, 150);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "End Date:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(226, 147);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(250, 27);
            dateTimeEnd.TabIndex = 2;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(241, 194);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(209, 55);
            btnGenerateReport.TabIndex = 4;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(183, 24);
            label3.Name = "label3";
            label3.Size = new Size(315, 37);
            label3.TabIndex = 5;
            label3.Text = "Product Sales Reporting";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmProductSaleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 419);
            Controls.Add(label3);
            Controls.Add(btnGenerateReport);
            Controls.Add(label2);
            Controls.Add(dateTimeEnd);
            Controls.Add(label1);
            Controls.Add(dateTimeStart);
            Name = "frmProductSaleReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Sales Reporting Tool";
            Load += frmProductSaleReport_Load;
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
    }
}
