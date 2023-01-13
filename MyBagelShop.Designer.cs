namespace MyBagelShop_22233517_Menghua_Guo
{
    partial class MyBagelShop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBagelShop));
            this.GroupBoxOrder = new System.Windows.Forms.GroupBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.LabelOneOrderCostDisplay = new System.Windows.Forms.Label();
            this.LabelOneOrderCost = new System.Windows.Forms.Label();
            this.ButtonAddOrder = new System.Windows.Forms.Button();
            this.TextBoxQuantityInput = new System.Windows.Forms.TextBox();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.LabelPriceAutoDisplay = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.ComboBoxSizeInput = new System.Windows.Forms.ComboBox();
            this.LabelSize = new System.Windows.Forms.Label();
            this.ComboBoxTypeInput = new System.Windows.Forms.ComboBox();
            this.LabelType = new System.Windows.Forms.Label();
            this.GroupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.LabelATotalCost = new System.Windows.Forms.Label();
            this.ButtonCompleteOrder = new System.Windows.Forms.Button();
            this.ListBoxOrderDetails = new System.Windows.Forms.ListBox();
            this.LabelOrderDetailsTitle = new System.Windows.Forms.Label();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.GroupBoxShowResults = new System.Windows.Forms.GroupBox();
            this.ButtonClearSearch = new System.Windows.Forms.Button();
            this.RadioButtonDate = new System.Windows.Forms.RadioButton();
            this.RadioButtonTrxID = new System.Windows.Forms.RadioButton();
            this.TextBoxSearchInput = new System.Windows.Forms.TextBox();
            this.ListBoxResults = new System.Windows.Forms.ListBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonSummaryReport = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.GroupBoxReports = new System.Windows.Forms.GroupBox();
            this.ButtonSalesReport = new System.Windows.Forms.Button();
            this.ButtonStockUpdateToFile = new System.Windows.Forms.Button();
            this.ToolTipAddOrder = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipClear = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipCompleteOrder = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipSummary = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipSalesReport = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipStockReport = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTipExit = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxOrder.SuspendLayout();
            this.GroupBoxOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.GroupBoxShowResults.SuspendLayout();
            this.GroupBoxReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxOrder
            // 
            this.GroupBoxOrder.Controls.Add(this.ButtonClear);
            this.GroupBoxOrder.Controls.Add(this.LabelOneOrderCostDisplay);
            this.GroupBoxOrder.Controls.Add(this.LabelOneOrderCost);
            this.GroupBoxOrder.Controls.Add(this.ButtonAddOrder);
            this.GroupBoxOrder.Controls.Add(this.TextBoxQuantityInput);
            this.GroupBoxOrder.Controls.Add(this.LabelQuantity);
            this.GroupBoxOrder.Controls.Add(this.LabelPriceAutoDisplay);
            this.GroupBoxOrder.Controls.Add(this.LabelPrice);
            this.GroupBoxOrder.Controls.Add(this.ComboBoxSizeInput);
            this.GroupBoxOrder.Controls.Add(this.LabelSize);
            this.GroupBoxOrder.Controls.Add(this.ComboBoxTypeInput);
            this.GroupBoxOrder.Controls.Add(this.LabelType);
            this.GroupBoxOrder.Location = new System.Drawing.Point(37, 31);
            this.GroupBoxOrder.Name = "GroupBoxOrder";
            this.GroupBoxOrder.Size = new System.Drawing.Size(922, 127);
            this.GroupBoxOrder.TabIndex = 0;
            this.GroupBoxOrder.TabStop = false;
            this.GroupBoxOrder.Text = "Order";
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonClear.Location = new System.Drawing.Point(743, 77);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(162, 34);
            this.ButtonClear.TabIndex = 12;
            this.ButtonClear.Text = "&Clear";
            this.ToolTipClear.SetToolTip(this.ButtonClear, "Press to Clear order");
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // LabelOneOrderCostDisplay
            // 
            this.LabelOneOrderCostDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.LabelOneOrderCostDisplay.Location = new System.Drawing.Point(366, 84);
            this.LabelOneOrderCostDisplay.Name = "LabelOneOrderCostDisplay";
            this.LabelOneOrderCostDisplay.Size = new System.Drawing.Size(113, 23);
            this.LabelOneOrderCostDisplay.TabIndex = 11;
            // 
            // LabelOneOrderCost
            // 
            this.LabelOneOrderCost.AutoSize = true;
            this.LabelOneOrderCost.Location = new System.Drawing.Point(298, 86);
            this.LabelOneOrderCost.Name = "LabelOneOrderCost";
            this.LabelOneOrderCost.Size = new System.Drawing.Size(53, 18);
            this.LabelOneOrderCost.TabIndex = 10;
            this.LabelOneOrderCost.Text = "Cost:";
            // 
            // ButtonAddOrder
            // 
            this.ButtonAddOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonAddOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAddOrder.Location = new System.Drawing.Point(555, 78);
            this.ButtonAddOrder.Name = "ButtonAddOrder";
            this.ButtonAddOrder.Size = new System.Drawing.Size(162, 34);
            this.ButtonAddOrder.TabIndex = 9;
            this.ButtonAddOrder.Text = "&Add to Order";
            this.ToolTipAddOrder.SetToolTip(this.ButtonAddOrder, "Press to Add an order");
            this.ButtonAddOrder.UseVisualStyleBackColor = false;
            this.ButtonAddOrder.Click += new System.EventHandler(this.ButtonAddOrder_Click);
            // 
            // TextBoxQuantityInput
            // 
            this.TextBoxQuantityInput.Location = new System.Drawing.Point(117, 81);
            this.TextBoxQuantityInput.Name = "TextBoxQuantityInput";
            this.TextBoxQuantityInput.Size = new System.Drawing.Size(100, 28);
            this.TextBoxQuantityInput.TabIndex = 8;
            this.TextBoxQuantityInput.TextChanged += new System.EventHandler(this.TextBoxQuantityInput_TextChanged);
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.AutoSize = true;
            this.LabelQuantity.Location = new System.Drawing.Point(21, 85);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(89, 18);
            this.LabelQuantity.TabIndex = 7;
            this.LabelQuantity.Text = "Quantity:";
            // 
            // LabelPriceAutoDisplay
            // 
            this.LabelPriceAutoDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPriceAutoDisplay.Location = new System.Drawing.Point(625, 30);
            this.LabelPriceAutoDisplay.Name = "LabelPriceAutoDisplay";
            this.LabelPriceAutoDisplay.Size = new System.Drawing.Size(113, 23);
            this.LabelPriceAutoDisplay.TabIndex = 6;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(557, 31);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(62, 18);
            this.LabelPrice.TabIndex = 5;
            this.LabelPrice.Text = "Price:";
            // 
            // ComboBoxSizeInput
            // 
            this.ComboBoxSizeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSizeInput.FormattingEnabled = true;
            this.ComboBoxSizeInput.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Regular",
            "Large",
            "Extra-large"});
            this.ComboBoxSizeInput.Location = new System.Drawing.Point(359, 27);
            this.ComboBoxSizeInput.Name = "ComboBoxSizeInput";
            this.ComboBoxSizeInput.Size = new System.Drawing.Size(152, 26);
            this.ComboBoxSizeInput.TabIndex = 4;
            this.ComboBoxSizeInput.TabStop = false;
            this.ComboBoxSizeInput.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSizeInput_SelectedIndexChanged);
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(299, 31);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(53, 18);
            this.LabelSize.TabIndex = 3;
            this.LabelSize.Text = "Size:";
            // 
            // ComboBoxTypeInput
            // 
            this.ComboBoxTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTypeInput.Items.AddRange(new object[] {
            "Plain",
            "Egg",
            "Everything",
            "Cinnamon",
            "Blueberry",
            "Chocolate",
            "Onion",
            "Asiago",
            "Salt",
            "Poppy",
            "French",
            "Whole Wheat",
            "Rainbow"});
            this.ComboBoxTypeInput.Location = new System.Drawing.Point(81, 28);
            this.ComboBoxTypeInput.Name = "ComboBoxTypeInput";
            this.ComboBoxTypeInput.Size = new System.Drawing.Size(180, 26);
            this.ComboBoxTypeInput.TabIndex = 2;
            this.ComboBoxTypeInput.TabStop = false;
            this.ComboBoxTypeInput.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTypeInput_SelectedIndexChanged);
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(22, 31);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(53, 18);
            this.LabelType.TabIndex = 0;
            this.LabelType.Text = "Type:";
            // 
            // GroupBoxOrderDetails
            // 
            this.GroupBoxOrderDetails.Controls.Add(this.LabelATotalCost);
            this.GroupBoxOrderDetails.Controls.Add(this.ButtonCompleteOrder);
            this.GroupBoxOrderDetails.Controls.Add(this.ListBoxOrderDetails);
            this.GroupBoxOrderDetails.Controls.Add(this.LabelOrderDetailsTitle);
            this.GroupBoxOrderDetails.Location = new System.Drawing.Point(37, 194);
            this.GroupBoxOrderDetails.Name = "GroupBoxOrderDetails";
            this.GroupBoxOrderDetails.Size = new System.Drawing.Size(660, 331);
            this.GroupBoxOrderDetails.TabIndex = 2;
            this.GroupBoxOrderDetails.TabStop = false;
            this.GroupBoxOrderDetails.Text = "Order Details";
            // 
            // LabelATotalCost
            // 
            this.LabelATotalCost.BackColor = System.Drawing.SystemColors.Window;
            this.LabelATotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelATotalCost.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelATotalCost.Location = new System.Drawing.Point(22, 220);
            this.LabelATotalCost.Name = "LabelATotalCost";
            this.LabelATotalCost.Size = new System.Drawing.Size(617, 37);
            this.LabelATotalCost.TabIndex = 11;
            // 
            // ButtonCompleteOrder
            // 
            this.ButtonCompleteOrder.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonCompleteOrder.Enabled = false;
            this.ButtonCompleteOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCompleteOrder.Location = new System.Drawing.Point(477, 275);
            this.ButtonCompleteOrder.Name = "ButtonCompleteOrder";
            this.ButtonCompleteOrder.Size = new System.Drawing.Size(162, 34);
            this.ButtonCompleteOrder.TabIndex = 10;
            this.ButtonCompleteOrder.Text = "&Complete Order";
            this.ToolTipCompleteOrder.SetToolTip(this.ButtonCompleteOrder, "Press to Complete order");
            this.ButtonCompleteOrder.UseVisualStyleBackColor = false;
            this.ButtonCompleteOrder.Click += new System.EventHandler(this.ButtonCompleteOrder_Click);
            // 
            // ListBoxOrderDetails
            // 
            this.ListBoxOrderDetails.FormattingEnabled = true;
            this.ListBoxOrderDetails.ItemHeight = 18;
            this.ListBoxOrderDetails.Location = new System.Drawing.Point(22, 54);
            this.ListBoxOrderDetails.Name = "ListBoxOrderDetails";
            this.ListBoxOrderDetails.Size = new System.Drawing.Size(617, 166);
            this.ListBoxOrderDetails.TabIndex = 1;
            // 
            // LabelOrderDetailsTitle
            // 
            this.LabelOrderDetailsTitle.Location = new System.Drawing.Point(47, 25);
            this.LabelOrderDetailsTitle.Name = "LabelOrderDetailsTitle";
            this.LabelOrderDetailsTitle.Size = new System.Drawing.Size(572, 26);
            this.LabelOrderDetailsTitle.TabIndex = 0;
            this.LabelOrderDetailsTitle.Text = "Type          Size         Quantity      Price      Total Cost";
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLogo.Image")));
            this.PictureBoxLogo.InitialImage = null;
            this.PictureBoxLogo.Location = new System.Drawing.Point(724, 194);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(229, 112);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 3;
            this.PictureBoxLogo.TabStop = false;
            // 
            // GroupBoxShowResults
            // 
            this.GroupBoxShowResults.Controls.Add(this.ButtonClearSearch);
            this.GroupBoxShowResults.Controls.Add(this.RadioButtonDate);
            this.GroupBoxShowResults.Controls.Add(this.RadioButtonTrxID);
            this.GroupBoxShowResults.Controls.Add(this.TextBoxSearchInput);
            this.GroupBoxShowResults.Controls.Add(this.ListBoxResults);
            this.GroupBoxShowResults.Controls.Add(this.ButtonSearch);
            this.GroupBoxShowResults.Location = new System.Drawing.Point(37, 531);
            this.GroupBoxShowResults.Name = "GroupBoxShowResults";
            this.GroupBoxShowResults.Size = new System.Drawing.Size(922, 347);
            this.GroupBoxShowResults.TabIndex = 4;
            this.GroupBoxShowResults.TabStop = false;
            this.GroupBoxShowResults.Text = "Search Transaction Details";
            // 
            // ButtonClearSearch
            // 
            this.ButtonClearSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonClearSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonClearSearch.Location = new System.Drawing.Point(740, 261);
            this.ButtonClearSearch.Name = "ButtonClearSearch";
            this.ButtonClearSearch.Size = new System.Drawing.Size(162, 34);
            this.ButtonClearSearch.TabIndex = 19;
            this.ButtonClearSearch.Text = "&Search Clear";
            this.ToolTipSearch.SetToolTip(this.ButtonClearSearch, "Press to Search Transactions");
            this.ButtonClearSearch.UseVisualStyleBackColor = false;
            this.ButtonClearSearch.Click += new System.EventHandler(this.ButtonClearSearch_Click);
            // 
            // RadioButtonDate
            // 
            this.RadioButtonDate.AutoSize = true;
            this.RadioButtonDate.Location = new System.Drawing.Point(730, 80);
            this.RadioButtonDate.Name = "RadioButtonDate";
            this.RadioButtonDate.Size = new System.Drawing.Size(186, 22);
            this.RadioButtonDate.TabIndex = 18;
            this.RadioButtonDate.Text = "Date (DD-MM-YYYY)";
            this.RadioButtonDate.UseVisualStyleBackColor = true;
            // 
            // RadioButtonTrxID
            // 
            this.RadioButtonTrxID.AutoSize = true;
            this.RadioButtonTrxID.Checked = true;
            this.RadioButtonTrxID.Location = new System.Drawing.Point(731, 40);
            this.RadioButtonTrxID.Name = "RadioButtonTrxID";
            this.RadioButtonTrxID.Size = new System.Drawing.Size(159, 22);
            this.RadioButtonTrxID.TabIndex = 17;
            this.RadioButtonTrxID.TabStop = true;
            this.RadioButtonTrxID.Text = "Transaction ID";
            this.RadioButtonTrxID.UseVisualStyleBackColor = true;
            // 
            // TextBoxSearchInput
            // 
            this.TextBoxSearchInput.Location = new System.Drawing.Point(743, 131);
            this.TextBoxSearchInput.Name = "TextBoxSearchInput";
            this.TextBoxSearchInput.Size = new System.Drawing.Size(159, 28);
            this.TextBoxSearchInput.TabIndex = 16;
            // 
            // ListBoxResults
            // 
            this.ListBoxResults.FormattingEnabled = true;
            this.ListBoxResults.ItemHeight = 18;
            this.ListBoxResults.Location = new System.Drawing.Point(22, 40);
            this.ListBoxResults.Name = "ListBoxResults";
            this.ListBoxResults.Size = new System.Drawing.Size(683, 292);
            this.ListBoxResults.TabIndex = 0;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSearch.Location = new System.Drawing.Point(740, 191);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(162, 34);
            this.ButtonSearch.TabIndex = 13;
            this.ButtonSearch.Text = "&Search";
            this.ToolTipSearch.SetToolTip(this.ButtonSearch, "Press to Search Transactions");
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonSummaryReport
            // 
            this.ButtonSummaryReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonSummaryReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSummaryReport.Location = new System.Drawing.Point(47, 133);
            this.ButtonSummaryReport.Name = "ButtonSummaryReport";
            this.ButtonSummaryReport.Size = new System.Drawing.Size(162, 34);
            this.ButtonSummaryReport.TabIndex = 14;
            this.ButtonSummaryReport.Text = "&Summary Report";
            this.ToolTipSummary.SetToolTip(this.ButtonSummaryReport, "Press to View Summary Details");
            this.ButtonSummaryReport.UseVisualStyleBackColor = false;
            this.ButtonSummaryReport.Click += new System.EventHandler(this.ButtonSummaryReport_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonExit.Location = new System.Drawing.Point(777, 884);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(162, 34);
            this.ButtonExit.TabIndex = 15;
            this.ButtonExit.Text = "E&xit";
            this.ToolTipExit.SetToolTip(this.ButtonExit, "Press to Exit the application");
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // GroupBoxReports
            // 
            this.GroupBoxReports.Controls.Add(this.ButtonSalesReport);
            this.GroupBoxReports.Controls.Add(this.ButtonStockUpdateToFile);
            this.GroupBoxReports.Controls.Add(this.ButtonSummaryReport);
            this.GroupBoxReports.Location = new System.Drawing.Point(730, 336);
            this.GroupBoxReports.Name = "GroupBoxReports";
            this.GroupBoxReports.Size = new System.Drawing.Size(229, 189);
            this.GroupBoxReports.TabIndex = 17;
            this.GroupBoxReports.TabStop = false;
            this.GroupBoxReports.Text = "Reports";
            // 
            // ButtonSalesReport
            // 
            this.ButtonSalesReport.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonSalesReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSalesReport.Location = new System.Drawing.Point(47, 34);
            this.ButtonSalesReport.Name = "ButtonSalesReport";
            this.ButtonSalesReport.Size = new System.Drawing.Size(162, 34);
            this.ButtonSalesReport.TabIndex = 18;
            this.ButtonSalesReport.Text = "&Sales Report";
            this.ToolTipSalesReport.SetToolTip(this.ButtonSalesReport, "Press to Generate daily sales report");
            this.ButtonSalesReport.UseVisualStyleBackColor = false;
            this.ButtonSalesReport.Click += new System.EventHandler(this.ButtonSalesReport_Click);
            // 
            // ButtonStockUpdateToFile
            // 
            this.ButtonStockUpdateToFile.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonStockUpdateToFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonStockUpdateToFile.Location = new System.Drawing.Point(47, 84);
            this.ButtonStockUpdateToFile.Name = "ButtonStockUpdateToFile";
            this.ButtonStockUpdateToFile.Size = new System.Drawing.Size(162, 34);
            this.ButtonStockUpdateToFile.TabIndex = 19;
            this.ButtonStockUpdateToFile.Text = "&Stock to File";
            this.ToolTipStockReport.SetToolTip(this.ButtonStockUpdateToFile, "Press to Generate stock report");
            this.ButtonStockUpdateToFile.UseVisualStyleBackColor = false;
            this.ButtonStockUpdateToFile.Click += new System.EventHandler(this.ButtonStockToFile_Click);
            // 
            // ToolTipAddOrder
            // 
            this.ToolTipAddOrder.IsBalloon = true;
            this.ToolTipAddOrder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipAddOrder.ToolTipTitle = "Info";
            // 
            // ToolTipClear
            // 
            this.ToolTipClear.IsBalloon = true;
            this.ToolTipClear.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipClear.ToolTipTitle = "Info";
            // 
            // ToolTipCompleteOrder
            // 
            this.ToolTipCompleteOrder.IsBalloon = true;
            this.ToolTipCompleteOrder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipCompleteOrder.ToolTipTitle = "Info";
            // 
            // ToolTipSearch
            // 
            this.ToolTipSearch.IsBalloon = true;
            this.ToolTipSearch.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipSearch.ToolTipTitle = "Info";
            // 
            // ToolTipSummary
            // 
            this.ToolTipSummary.IsBalloon = true;
            this.ToolTipSummary.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipSummary.ToolTipTitle = "Info";
            // 
            // ToolTipSalesReport
            // 
            this.ToolTipSalesReport.IsBalloon = true;
            this.ToolTipSalesReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipSalesReport.ToolTipTitle = "Info";
            // 
            // ToolTipStockReport
            // 
            this.ToolTipStockReport.IsBalloon = true;
            this.ToolTipStockReport.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipStockReport.ToolTipTitle = "Info";
            // 
            // ToolTipExit
            // 
            this.ToolTipExit.IsBalloon = true;
            this.ToolTipExit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipExit.ToolTipTitle = "Info";
            // 
            // MyBagelShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 930);
            this.Controls.Add(this.GroupBoxReports);
            this.Controls.Add(this.GroupBoxShowResults);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.PictureBoxLogo);
            this.Controls.Add(this.GroupBoxOrderDetails);
            this.Controls.Add(this.GroupBoxOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Name = "MyBagelShop";
            this.Text = "MyBagelShop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyBagelShop_FormClosing);
            this.Load += new System.EventHandler(this.MyBagelShop_Load);
            this.GroupBoxOrder.ResumeLayout(false);
            this.GroupBoxOrder.PerformLayout();
            this.GroupBoxOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.GroupBoxShowResults.ResumeLayout(false);
            this.GroupBoxShowResults.PerformLayout();
            this.GroupBoxReports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxOrder;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.ComboBox ComboBoxTypeInput;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.ComboBox ComboBoxSizeInput;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelPriceAutoDisplay;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.TextBox TextBoxQuantityInput;
        private System.Windows.Forms.Button ButtonAddOrder;
        private System.Windows.Forms.Label LabelOneOrderCostDisplay;
        private System.Windows.Forms.Label LabelOneOrderCost;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.GroupBox GroupBoxOrderDetails;
        private System.Windows.Forms.ListBox ListBoxOrderDetails;
        private System.Windows.Forms.Label LabelOrderDetailsTitle;
        private System.Windows.Forms.Button ButtonCompleteOrder;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
        private System.Windows.Forms.GroupBox GroupBoxShowResults;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonSummaryReport;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ListBox ListBoxResults;
        private System.Windows.Forms.TextBox TextBoxSearchInput;
        private System.Windows.Forms.GroupBox GroupBoxReports;
        private System.Windows.Forms.Button ButtonSalesReport;
        private System.Windows.Forms.Button ButtonStockUpdateToFile;
        private System.Windows.Forms.ToolTip ToolTipAddOrder;
        private System.Windows.Forms.ToolTip ToolTipClear;
        private System.Windows.Forms.ToolTip ToolTipCompleteOrder;
        private System.Windows.Forms.ToolTip ToolTipSearch;
        private System.Windows.Forms.ToolTip ToolTipSummary;
        private System.Windows.Forms.ToolTip ToolTipSalesReport;
        private System.Windows.Forms.ToolTip ToolTipStockReport;
        private System.Windows.Forms.ToolTip ToolTipExit;
        private System.Windows.Forms.RadioButton RadioButtonTrxID;
        private System.Windows.Forms.RadioButton RadioButtonDate;
        private System.Windows.Forms.Button ButtonClearSearch;
        private System.Windows.Forms.Label LabelATotalCost;
    }
}

