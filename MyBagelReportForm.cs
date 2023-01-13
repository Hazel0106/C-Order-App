// Subform - Report form
// This part is for displaying receipt/sales/summary reports

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBagelShop_22233517_Menghua_Guo
{
    public partial class MyBagelReportForm : Form
    {
        public MyBagelReportForm()
        {
            InitializeComponent();
        }

        // Format & display sales report
        public void LoadSalesReportForm(string[] salesType, string[] salesSize, int[] quantitySold, int[,] stock, decimal[,] salesPrices, string fileName)
        {
            string salesItems = "", date, sizeMessage;
            decimal itemTotalCost = 0m, totalSalesAmount = 0m;
            int oneTypeSoldAmount = 0;
            ListBoxReportDetails.Items.Clear();
            date = DateTime.Now.ToString("dd-MM-yyyy");
            LabelSalesReportTitle.Text = $"MyBagelShop Inc. (MBSI)\t\t\tDate:\t{date}";
            sizeMessage = $"\t\tS\t\tM\t\tR\t\tL\t\tXL\t\tTotal Sold\tTotal Cost";
            ListBoxReportDetails.Items.Add(sizeMessage);
            try
            {
                for (int row = 0; row < salesType.Length; row++)
                {
                    for (int col = 0; col < salesSize.Length; col++)
                    {
                        quantitySold[col] = stock[row, col];
                        oneTypeSoldAmount += quantitySold[col];
                        itemTotalCost += salesPrices[row, col] * quantitySold[col];
                    }
                    totalSalesAmount += itemTotalCost;
                    if (salesType[row].Length >= 8)
                    {
                        salesItems = $"{salesType[row]}\t{String.Join("\t\t", quantitySold)}\t\t{oneTypeSoldAmount}\t\t{itemTotalCost.ToString("C2")}";
                    }
                    else
                    {
                        salesItems = $"{salesType[row]}\t\t{String.Join("\t\t", quantitySold)}\t\t{oneTypeSoldAmount}\t\t{itemTotalCost.ToString("C2")}";
                    }
                    ListBoxReportDetails.Items.Add(salesItems);
                    itemTotalCost = 0m;
                    oneTypeSoldAmount = 0;
                }
                LabelTotalSalesAmount.Text = $"Total Sales Amount:      {totalSalesAmount.ToString("C2")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            totalSalesAmount = itemTotalCost = 0m;
            Array.Clear(quantitySold, 0, quantitySold.Length);
        }

        // Format & display summary report
        internal void LoadSummaryReportForm(int soldNo, int trxNo, decimal totalSalesValue,  decimal avgValue)
        {
            string date;
            ListBoxReportDetails.Items.Clear();
            Text = "MyBagel Daily Summary";
            date = DateTime.Now.ToString("dd-MM-yyyy");
            LabelSalesReportTitle.Text = $"MyBagelShop Inc. (MBSI)        Date:\t{date}";
            ListBoxReportDetails.Items.Add($"Total Number of Sold:\t\t\t{soldNo}");
            ListBoxReportDetails.Items.Add($"Total Number of Transactions:\t\t{trxNo}");
            ListBoxReportDetails.Items.Add($"Total Sales Amount:\t\t\t{totalSalesValue.ToString("C")}");
            ListBoxReportDetails.Items.Add($"Average Amount of Transactions:  \t{avgValue.ToString("C")}");
        }

        //Format & display receipt
        internal void LoadReceiptForm(string trxUID, List<string> items, decimal totalCost)
        {
            string date;
            ListBoxReportDetails.Items.Clear();
            Text = "MyBagel Order Receipt";
            date = DateTime.Now.ToString("dd-MM-yyyy");
            LabelSalesReportTitle.Text = $"MyBagelShop Inc. (MBSI)";
            ListBoxReportDetails.Items.Add($"Transaction ID:\t\t{trxUID}");
            ListBoxReportDetails.Items.Add($"Transaction Date:\t{date}");
            for (int i = 0; i < items.Count; i++)
            {
                ListBoxReportDetails.Items.Add(items[i]);
            }
            ListBoxReportDetails.Items.Add($"Total Cost:\t\t{totalCost.ToString("C")}");
        }

        // Close the report form
        private void ButtonReportExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
