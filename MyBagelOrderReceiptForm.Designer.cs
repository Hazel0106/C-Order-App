namespace MyBagelShop_22233517_Menghua_Guo
{
    partial class MyBagelOrderReceiptForm
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
            this.PanelReceipt = new System.Windows.Forms.Panel();
            this.ButtonReciptExit = new System.Windows.Forms.Button();
            this.LabelReceipt = new System.Windows.Forms.Label();
            this.ListBoxReceipt = new System.Windows.Forms.ListBox();
            this.PanelReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelReceipt
            // 
            this.PanelReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelReceipt.Controls.Add(this.ListBoxReceipt);
            this.PanelReceipt.Controls.Add(this.LabelReceipt);
            this.PanelReceipt.Location = new System.Drawing.Point(37, 23);
            this.PanelReceipt.Name = "PanelReceipt";
            this.PanelReceipt.Size = new System.Drawing.Size(729, 389);
            this.PanelReceipt.TabIndex = 0;
            // 
            // ButtonReciptExit
            // 
            this.ButtonReciptExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonReciptExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonReciptExit.Location = new System.Drawing.Point(658, 428);
            this.ButtonReciptExit.Name = "ButtonReciptExit";
            this.ButtonReciptExit.Size = new System.Drawing.Size(108, 34);
            this.ButtonReciptExit.TabIndex = 17;
            this.ButtonReciptExit.Text = "E&xit";
            this.ButtonReciptExit.UseVisualStyleBackColor = false;
            this.ButtonReciptExit.Click += new System.EventHandler(this.ButtonReciptExit_Click);
            // 
            // LabelReceipt
            // 
            this.LabelReceipt.Location = new System.Drawing.Point(21, 13);
            this.LabelReceipt.Name = "LabelReceipt";
            this.LabelReceipt.Size = new System.Drawing.Size(688, 49);
            this.LabelReceipt.TabIndex = 0;
            // 
            // ListBoxReceipt
            // 
            this.ListBoxReceipt.FormattingEnabled = true;
            this.ListBoxReceipt.ItemHeight = 18;
            this.ListBoxReceipt.Location = new System.Drawing.Point(24, 78);
            this.ListBoxReceipt.Name = "ListBoxReceipt";
            this.ListBoxReceipt.Size = new System.Drawing.Size(685, 274);
            this.ListBoxReceipt.TabIndex = 1;
            // 
            // MyBagelOrderReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.ButtonReciptExit);
            this.Controls.Add(this.PanelReceipt);
            this.Name = "MyBagelOrderReceiptForm";
            this.Text = "MyBagelOrderReceiptForm";
            this.PanelReceipt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelReceipt;
        private System.Windows.Forms.Button ButtonReciptExit;
        private System.Windows.Forms.Label LabelReceipt;
        private System.Windows.Forms.ListBox ListBoxReceipt;
    }
}