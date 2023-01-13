namespace MyBagelShop_22233517_Menghua_Guo
{
    partial class MyBagelReportForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelReportForm));
            this.PanelSalesReport = new System.Windows.Forms.Panel();
            this.LabelTotalSalesAmount = new System.Windows.Forms.Label();
            this.ListBoxReportDetails = new System.Windows.Forms.ListBox();
            this.ButtonReportExit = new System.Windows.Forms.Button();
            this.LabelSalesReportTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSalesReport
            // 
            this.PanelSalesReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelSalesReport.Controls.Add(this.LabelTotalSalesAmount);
            this.PanelSalesReport.Controls.Add(this.ListBoxReportDetails);
            this.PanelSalesReport.Controls.Add(this.ButtonReportExit);
            this.PanelSalesReport.Controls.Add(this.LabelSalesReportTitle);
            this.PanelSalesReport.Location = new System.Drawing.Point(34, 33);
            this.PanelSalesReport.Name = "PanelSalesReport";
            this.PanelSalesReport.Size = new System.Drawing.Size(1264, 458);
            this.PanelSalesReport.TabIndex = 0;
            // 
            // LabelTotalSalesAmount
            // 
            this.LabelTotalSalesAmount.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTotalSalesAmount.Location = new System.Drawing.Point(19, 378);
            this.LabelTotalSalesAmount.Name = "LabelTotalSalesAmount";
            this.LabelTotalSalesAmount.Size = new System.Drawing.Size(911, 49);
            this.LabelTotalSalesAmount.TabIndex = 17;
            // 
            // ListBoxReportDetails
            // 
            this.ListBoxReportDetails.FormattingEnabled = true;
            this.ListBoxReportDetails.HorizontalScrollbar = true;
            this.ListBoxReportDetails.ItemHeight = 18;
            this.ListBoxReportDetails.Location = new System.Drawing.Point(19, 61);
            this.ListBoxReportDetails.Name = "ListBoxReportDetails";
            this.ListBoxReportDetails.ScrollAlwaysVisible = true;
            this.ListBoxReportDetails.Size = new System.Drawing.Size(1220, 310);
            this.ListBoxReportDetails.TabIndex = 1;
            // 
            // ButtonReportExit
            // 
            this.ButtonReportExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonReportExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonReportExit.Location = new System.Drawing.Point(1131, 409);
            this.ButtonReportExit.Name = "ButtonReportExit";
            this.ButtonReportExit.Size = new System.Drawing.Size(108, 34);
            this.ButtonReportExit.TabIndex = 16;
            this.ButtonReportExit.Text = "E&xit";
            this.ButtonReportExit.UseVisualStyleBackColor = false;
            this.ButtonReportExit.Click += new System.EventHandler(this.ButtonReportExit_Click);
            // 
            // LabelSalesReportTitle
            // 
            this.LabelSalesReportTitle.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelSalesReportTitle.Location = new System.Drawing.Point(15, 9);
            this.LabelSalesReportTitle.Name = "LabelSalesReportTitle";
            this.LabelSalesReportTitle.Size = new System.Drawing.Size(1120, 49);
            this.LabelSalesReportTitle.TabIndex = 0;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.InitialImage = null;
            this.PictureBoxLogo.Location = new System.Drawing.Point(516, 509);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(229, 112);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 17;
            this.PictureBoxLogo.TabStop = false;
            // 
            // MyBagelReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 621);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.PanelSalesReport);
            this.Name = "MyBagelReportForm";
            this.Text = "MyBagel Daily Sales Report";
            this.PanelSalesReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSalesReport;
        private System.Windows.Forms.ListBox ListBoxReportDetails;
        private System.Windows.Forms.Button ButtonReportExit;
        private System.Windows.Forms.Label LabelSalesReportTitle;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.Label LabelTotalSalesAmount;
    }
}