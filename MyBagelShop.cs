/* Student Name: Menghua Guo
 * Student ID: 22233517
 * Date:28/11/2022
 * Assignment: 4
 * Assignment: Create an EPOS application for MBSI. Functions include: processing orders, recording order details, searching transactions, managing inventory, generating sales/stock/summary reports.
 */

// This part is the Main form functions

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace MyBagelShop_22233517_Menghua_Guo
{
    public partial class MyBagelShop : Form
    {
        private decimal[,] bagelPrices = new decimal[bagelTypes.Length, bagelSizes.Length];
        private int[,] stocks = new int[bagelTypes.Length, bagelSizes.Length], tempBagelStock = new int[bagelTypes.Length, bagelSizes.Length], salesStock = new int[bagelTypes.Length, bagelSizes.Length];
        public static string[] bagelTypes = { "Plain", "Egg", "Everything", "Cinnamon", "Blueberry", "Chocolate", "Onion", "Asiago", "Salt", "Poppy", "French", "Whole Wheat", "Rainbow" };
        private static string[] bagelSizes = { "Small", "Medium", "Regular", "Large", "Extra-large" };
        private const string transactionFile = "TransactionsRecord.txt", priceFile = "PriceList.txt", stockFile = "Stock.txt";
        private readonly char[] delim = { ';' };
        private const int trxUID_Index = 0, date_Index = 1, totalCost_Index = 2;
        private string trxUID, typeSelected, sizeSelected, itemList, trxDate;
        private int typeIndex, sizeIndex, quantitySelected, totalQuantitySold, dailyTrxNo;
        private decimal runningTotalCost = 0m, dailySalesAmount, avgOrdersAmount;
        private List<string> receiptItems = new List<string>();

        public MyBagelShop()
        {
            InitializeComponent();
        }

        // Write decimal prices into file
        private void WritePriceList(object sender, EventArgs e)
        {
            try
            {
                StreamWriter priceListWrite = File.CreateText(priceFile);
                decimal[,] prices =
            { { 2.05m, 2.10m, 2.15m, 2.20m, 2.25m },
            { 2.15m, 2.20m, 2.25m, 2.30m, 2.35m },
            { 2.50m, 2.60m, 2.70m, 2.80m, 2.90m },
            { 2.25m, 2.30m, 2.35m, 2.40m, 2.45m },
            { 2.40m, 2.45m, 2.50m, 2.55m, 2.60m },
            { 2.65m, 2.75m, 2.85m, 2.95m, 3.05m },
            { 2.35m, 2.40m, 2.45m, 2.50m, 2.55m },
            { 2.45m, 2.55m, 2.65m, 2.75m, 2.85m },
            { 2.15m, 2.20m, 2.25m, 2.30m, 2.35m },
            { 2.50m, 2.60m, 2.70m, 2.80m, 2.90m },
            { 2.75m, 3.00m, 3.25m, 3.50m, 3.75m },
            { 2.55m, 2.65m, 2.75m, 2.85m, 2.90m },
            { 2.75m, 3.05m, 3.35m, 3.70m, 4.00m } };
                for (int row = 0; row < bagelTypes.Length; row++)
                {
                    for (int col = 0; col < bagelSizes.Length; col++)
                    {
                        priceListWrite.Write(prices[row, col] + ";");
                    }
                    priceListWrite.Write("\n");
                }
                priceListWrite.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyBagelShop_Load(object sender, EventArgs e)
        {
            // Read price & stock data from files in the loading process
            WritePriceList(sender, e);
            Load2DDecimalDataFromFile(priceFile, ref bagelPrices);
            Load2DIntDataFromFile(stockFile, ref stocks);
            Load2DIntDataFromFile(stockFile, ref tempBagelStock);
        }

        // Read 2D decimal arrays data from files - prices
        private bool Load2DDecimalDataFromFile(string file, ref decimal[,] records)
        {
            string[] recordRow, recordsLoad;
            recordsLoad = File.ReadAllLines(file);
            try
            {
                for (int row = 0; row < recordsLoad.Length; row++)
                {
                    recordRow = recordsLoad[row].Split(delim);
                    for (int col = 0; col < records.GetLength(1); col++)
                    {
                        records[row, col] = decimal.Parse(recordRow[col]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // Read 2D int arrays data from files - stocks
        private bool Load2DIntDataFromFile(string file, ref int[,] records)
        {
            string[] recordRow, recordsLoad;
            recordsLoad = File.ReadAllLines(file);
            try
            {
                for (int row = 0; row < recordsLoad.Length; row++)
                {
                    recordRow = recordsLoad[row].Split(delim);
                    for (int col = 0; col < records.GetLength(1); col++)
                    {
                        records[row, col] = int.Parse(recordRow[col]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        // the index of size needs to be clear when type change
        private void ComboBoxTypeInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxSizeInput.SelectedIndex = -1;
            TextBoxQuantityInput.Text = LabelPriceAutoDisplay.Text = "";
        }

        // Auto display single item price
        private void ComboBoxSizeInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeInput.SelectedIndex == -1 || ComboBoxSizeInput.SelectedIndex == -1)
            {
                LabelPriceAutoDisplay.Text = "";
            }
            else
            {
                LabelPriceAutoDisplay.Text = bagelPrices[ComboBoxTypeInput.SelectedIndex, ComboBoxSizeInput.SelectedIndex].ToString("C");
            }
        }

        // Auto display total price of one order
        private void TextBoxQuantityInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int quantity;
                if (ComboBoxTypeInput.SelectedIndex == -1 || ComboBoxSizeInput.SelectedIndex == -1 || String.IsNullOrWhiteSpace(TextBoxQuantityInput.Text))
                {
                    LabelOneOrderCostDisplay.Text = "";
                }
                else
                {
                    quantity = int.Parse(TextBoxQuantityInput.Text);
                    LabelOneOrderCostDisplay.Text = (bagelPrices[ComboBoxTypeInput.SelectedIndex, ComboBoxSizeInput.SelectedIndex] * quantity).ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Add items to the order details listbox
        private void ButtonAddOrder_Click(object sender, EventArgs e)
        {
            int livingStock;
            typeIndex = ComboBoxTypeInput.SelectedIndex;
            typeSelected = ComboBoxTypeInput.Text;
            sizeIndex = ComboBoxSizeInput.SelectedIndex;
            sizeSelected = ComboBoxSizeInput.Text;
            if (typeIndex == -1)
            {
                MessageBox.Show("Please choose a type for order!");
            }
            else if (sizeIndex == -1)
            {
                MessageBox.Show("Please choose a size for order!");
            }
            else if (TextBoxQuantityInput.Text == null)
            {
                MessageBox.Show("Please enter quantity for order!");
            }
            else
            {
                try
                {
                    quantitySelected = int.Parse(TextBoxQuantityInput.Text);
                    livingStock = tempBagelStock[typeIndex, sizeIndex];
                    if (quantitySelected <= 0)
                    {
                        MessageBox.Show("Please enter a valid quantity!", "Valid Number Needed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextBoxQuantityInput.Focus();
                        TextBoxQuantityInput.SelectAll();
                    }
                    else if (quantitySelected <= livingStock)
                    {
                        string listboxDetails, itemDetails = "";
                        decimal oneItemPrice = bagelPrices[typeIndex, sizeIndex], total1Cost = oneItemPrice * quantitySelected;
                        // Format display details
                        LabelPriceAutoDisplay.Text = oneItemPrice.ToString("C");
                        LabelOneOrderCostDisplay.Text = total1Cost.ToString("C");
                        listboxDetails = String.Format("{0}\t{1}\t{2}\t{3}\t{4}", typeSelected, sizeSelected, quantitySelected, oneItemPrice.ToString("C"), total1Cost.ToString("C"));
                        ListBoxOrderDetails.Items.Add(listboxDetails);
                        receiptItems.Add($"Type: {typeSelected}; Size: {sizeSelected}; Quantity: {quantitySelected}; Price: {oneItemPrice}; Cost: {total1Cost}; ");
                        itemDetails = $"{typeSelected},{sizeSelected},{quantitySelected},{total1Cost.ToString("C")}";
                        itemList += $"{itemDetails};";
                        // check if stock > 0 
                        if (tempBagelStock[typeIndex, sizeIndex] > 0)
                        {
                            tempBagelStock[typeIndex, sizeIndex] -= quantitySelected;
                        }
                        runningTotalCost += total1Cost;
                        LabelATotalCost.Text = $"Total Cost:        {runningTotalCost.ToString("C2")}";
                        // Clear & Enable
                        ComboBoxTypeInput.SelectedIndex = ComboBoxSizeInput.SelectedIndex = -1;
                        LabelPriceAutoDisplay.Text = TextBoxQuantityInput.Text = LabelOneOrderCostDisplay.Text = "";
                        ButtonCompleteOrder.Enabled = true;
                    }
                    else
                    {
                        string availableStock;
                        if (livingStock <= 0)
                        {
                            MessageBox.Show("This bagel all sold out! Please select others!", "No Stock!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TextBoxQuantityInput.Text = "0";
                            TextBoxQuantityInput.Focus();
                            TextBoxQuantityInput.SelectAll();
                        }
                        else
                        {
                            availableStock = String.Format("The Available stock is: {0}", livingStock);
                            MessageBox.Show(availableStock, "Insufficient Stock!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            TextBoxQuantityInput.Text = livingStock.ToString();
                            TextBoxQuantityInput.Focus();
                            TextBoxQuantityInput.SelectAll();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        // Clear Button to clear all items for the next order
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            runningTotalCost = 0m;
            ComboBoxTypeInput.SelectedIndex = ComboBoxSizeInput.SelectedIndex = -1;
            LabelPriceAutoDisplay.Text = LabelOneOrderCostDisplay.Text = LabelOneOrderCostDisplay.Text = "";
            TextBoxQuantityInput.Clear();
            ListBoxOrderDetails.Items.Clear();
            ButtonCompleteOrder.Enabled = false;
            itemList = LabelATotalCost.Text = "";
            receiptItems.Clear();
        }

        private void GetTrxUID(object sender, EventArgs e)
        {
            // unique transaction ID: 'A987654'
            char capitalChar;
            int digit, charNum;
            Random charRandom = new Random();
            Random digitRandom = new Random();
            charNum = charRandom.Next(65, 91);
            capitalChar = Convert.ToChar(charNum);
            digit = digitRandom.Next(0, 999999);
            do
            {
                trxUID = capitalChar.ToString() + digit.ToString("D6");
            } while (UIDChecked(trxUID));
        }

        // check if the trxID is unique
        private bool UIDChecked(string trxUID)
        {
            bool idFound = false;
            try
            {
                string check;
                StreamReader uidDataStream;

                using (uidDataStream = new StreamReader(transactionFile)) ;
                uidDataStream = File.OpenText(transactionFile);
                while (!uidDataStream.EndOfStream)
                {
                    check = uidDataStream.ReadLine();
                    if (check.Contains(trxUID))
                    {
                        idFound = true;
                        break;
                    }
                }
                uidDataStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idFound;
        }

        // Complete one transacion
        private void ButtonCompleteOrder_Click(object sender, EventArgs e)
        {
            GetTrxUID(sender, e);
            trxDate = DateTime.Now.ToString("dd-MM-yyyy");
            // Verify if any order added
            if (ListBoxOrderDetails.Text == null)
            {
                MessageBox.Show("Please add an order!", "Order needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ComboBoxTypeInput.Focus();
            }
            else
            {
                try
                {
                    ComboBoxTypeInput.Enabled = ComboBoxSizeInput.Enabled = TextBoxQuantityInput.Enabled = false;
                    // Update transaction records into file
                    StreamWriter trxUpdateFile;
                    trxUpdateFile = File.AppendText(transactionFile);
                    trxUpdateFile.WriteLine($"{trxUID};{trxDate};{runningTotalCost};{itemList}");
                    trxUpdateFile.Close();
                    // Display receipt in another form
                    MyBagelReportForm receiptForm = new MyBagelReportForm();
                    receiptForm.LoadReceiptForm(trxUID, receiptItems, runningTotalCost);
                    receiptForm.ShowDialog();
                    // Clear items for next order & unable inputs
                    ButtonClear_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ComboBoxTypeInput.Enabled = ComboBoxSizeInput.Enabled = TextBoxQuantityInput.Enabled = true;
            runningTotalCost = 0m;
            itemList = "";
            receiptItems.Clear();
        }

        private int UIndexSearch(string searchContent, string[] searchArray)
        {
            for (int i = 0; i < searchArray.Length; i++)
            {
                if (searchArray[i].Contains(searchContent))
                {
                    return i;
                }
            }
            return -1;
        }

        private List<string> SearchAllContent(string searchContent, string[] searchArray)
        {
            List<string> searchResult = new List<string>();
            foreach (string searchLine in searchArray)
            {
                if (searchLine.Contains(searchContent))
                {
                    searchResult.Add(searchLine);
                }
            }
            return searchResult;
        }

        // Add data into search listbox
        private void LoadTrxDataToListBox(string line, ListBox listBoxResult)
        {
            string[] trx = line.Split(delim);
            string trxID = trx[trxUID_Index];
            string date = trx[date_Index];
            string totalCost = decimal.Parse(trx[totalCost_Index]).ToString("C2");
            listBoxResult.Items.Add($"Transaction ID: {trxID}");
            listBoxResult.Items.Add($"Date: \t\t{date}");
            for (int i = 3; i < trx.Length; i++)
            {
                listBoxResult.Items.Add(trx[i]);
            }
            listBoxResult.Items.Add($"Total Cost: {totalCost}");
            listBoxResult.Items.Add("");
            listBoxResult.Items.Add("-----------------------------------------------------------------------------");
        }

        // Search function
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = TextBoxSearchInput.Text;
                if (String.IsNullOrEmpty(TextBoxSearchInput.Text))
                {
                    MessageBox.Show("Please enter a valid Transaction ID or date!", "Input needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TextBoxSearchInput.Focus();
                    TextBoxSearchInput.SelectAll();
                }
                else if (!RadioButtonTrxID.Checked && !RadioButtonDate.Checked)
                {
                    MessageBox.Show("Please select a button to search!", "Input needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TextBoxSearchInput.Focus();
                    TextBoxSearchInput.SelectAll();
                }
                else
                {
                    string[] searchText = File.ReadAllLines(transactionFile);
                    if (RadioButtonTrxID.Checked)
                    {
                        int searchIndex = UIndexSearch(searchInput, searchText);
                        if (searchInput.Length != 7)
                        {
                            MessageBox.Show("Please enter a valid Transaction ID or date!", "Input needed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ButtonSearch.Enabled = RadioButtonTrxID.Checked = true;
                            TextBoxSearchInput.Focus();
                            TextBoxSearchInput.SelectAll();
                        }
                        else if (searchIndex != -1)
                        {
                            LoadTrxDataToListBox(searchText[searchIndex], ListBoxResults);
                        }
                        else
                        {
                            MessageBox.Show("Sorry, no result found!", "No Result Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ButtonSearch.Enabled = RadioButtonTrxID.Checked = true;
                        }
                    }
                    else
                    {
                        List<string> dailySales = SearchAllContent(searchInput, searchText);
                        if (dailySales != null)
                        {
                            for (int i = 0; i < dailySales.Count; i++)
                            {
                                LoadTrxDataToListBox(dailySales[i], ListBoxResults);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sorry, no result found!", "No Result Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ButtonSearch.Enabled = RadioButtonTrxID.Checked = true;
                            TextBoxSearchInput.Focus();
                            TextBoxSearchInput.SelectAll();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ButtonSearch.Enabled = false;
            TextBoxSearchInput.Text = "";
            RadioButtonTrxID.Checked = RadioButtonDate.Checked = false;
        }

        // Clear search details for next search
        private void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            ListBoxResults.Items.Clear();
            RadioButtonDate.Checked = false;
            RadioButtonTrxID.Checked = ButtonSearch.Enabled = true;
            TextBoxSearchInput.Text = "";
            TextBoxSearchInput.Focus();
            TextBoxSearchInput.SelectAll();
        }

        // Read data from transaction records file, cut each line into readable & practical data
        private void GetFormattedTrxDataFromFile(object sender, EventArgs e)
        {
            int quantityFound = 0, typeFound_Index, sizeFound_Index;
            string[] trxLines = File.ReadAllLines(transactionFile), oneTrxLine;
            string date = DateTime.Now.ToString("dd-MM-yyyy"), typeFound, sizeFound;
            List<string> dailyTrxData = SearchAllContent(date, trxLines);
            try
            {
                if (dailyTrxData.Count > 0)
                {
                    for (int i = 0; i < dailyTrxData.Count; i++)
                    {
                        oneTrxLine = dailyTrxData[i].Split(delim);
                        dailySalesAmount += decimal.Parse(oneTrxLine[totalCost_Index]);
                        for (int j = 3; j < oneTrxLine.Length - 1; j++)
                        {
                            string[] aTrx = oneTrxLine[j].Split(',');
                            typeFound = aTrx[0];
                            sizeFound = aTrx[1];
                            typeFound_Index = Array.FindIndex(bagelTypes, element => element.Equals(typeFound));
                            sizeFound_Index = Array.FindIndex(bagelSizes, element => element.Equals(sizeFound));
                            quantityFound = int.Parse(aTrx[2]);
                            totalQuantitySold += quantityFound;
                            salesStock[typeFound_Index, sizeFound_Index] += quantityFound;
                        }
                    }
                    dailyTrxNo = dailyTrxData.Count;
                }
                else
                {
                    MessageBox.Show("Please Add an order!", "No Result Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            quantityFound = 0;
        }

        // Daily summary report display
        private void ButtonSummaryReport_Click(object sender, EventArgs e)
        {
            try
            {
                MyBagelReportForm summaryReport = new MyBagelReportForm();
                GetFormattedTrxDataFromFile(sender, e);
                if (dailyTrxNo > 0)
                {
                    avgOrdersAmount = dailySalesAmount / (decimal)dailyTrxNo;
                }
                summaryReport.LoadSummaryReportForm(totalQuantitySold, dailyTrxNo, dailySalesAmount, avgOrdersAmount);
                summaryReport.ShowDialog();
                dailyTrxNo = totalQuantitySold = 0;
                dailySalesAmount = 0m;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Array.Clear(salesStock, 0, salesStock.Length);
        }

        // Generate daily sales report with another form
        private void ButtonSalesReport_Click(object sender, EventArgs e)
        {
            MyBagelReportForm dailySalesReport = new MyBagelReportForm();
            int[] quantitySold = new int[salesStock.GetLength(1)];
            GetFormattedTrxDataFromFile(sender, e);
            dailySalesReport.LoadSalesReportForm(bagelTypes, bagelSizes, quantitySold, salesStock, bagelPrices, transactionFile);
            Array.Clear(quantitySold, 0, quantitySold.Length);
            Array.Clear(salesStock, 0, salesStock.Length);
            dailySalesReport.ShowDialog();
            dailyTrxNo = totalQuantitySold = 0;
            dailySalesAmount = 0m;
        }
        

        // Generate stock report
        private void ButtonStockToFile_Click(object sender, EventArgs e)
        {
            string header1 = $"Date:\t{DateTime.Now.ToString("dd-MM-yyyy")}, Generate Time:\t{DateTime.Now.ToString("HH:mm:ss")}", header2 = "Available Stock", stockType = "";
            int[] stockLine = new int[tempBagelStock.GetLength(1)];

            try
            {
                StreamWriter stockReport = File.CreateText("StockReport.txt");
                stockReport.Write(header1);
                stockReport.Write("\n\n");
                stockReport.Write(header2);
                stockReport.Write("\n\n");
                stockReport.Write($"\t\t\tS\t\tM\t\tR\t\tL\t\tXL");
                stockReport.Write("\n");
                for (int row = 0; row < tempBagelStock.GetLength(0); row++)
                {
                    for (int col = 0; col < tempBagelStock.GetLength(1); col++)
                    {
                        stockLine[col] = tempBagelStock[row, col];
                    }
                    // display the formatted report
                    if (bagelTypes[row].Length >= 11)
                    {
                        stockType = $"{bagelTypes[row]}\t{String.Join("\t\t",stockLine)}";
                    }
                    else if (bagelTypes[row].Length >= 6)
                    {
                        stockType = $"{bagelTypes[row]}\t\t{String.Join("\t\t", stockLine)}";
                    }
                    else if (bagelTypes[row] == "Poppy")
                    {
                        stockType = $"{bagelTypes[row]}\t\t{String.Join("\t\t", stockLine)}";
                    }
                    else
                    {
                        stockType = $"{bagelTypes[row]}\t\t\t{String.Join("\t\t", stockLine)}";
                    }
                    stockReport.WriteLine(stockType);
                }
                stockReport.Close();
                MessageBox.Show("Please open StockReport.txt File in debug folder to Check!", "Check File!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update stocks data into file when closing the main form
        private void MyBagelShop_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter updateStockFile;
                int[] stockRow = new int[tempBagelStock.GetLength(1)];
                updateStockFile = File.CreateText(stockFile);
                for (int row = 0; row < tempBagelStock.GetLength(0); row++)
                {
                    for (int col = 0; col < tempBagelStock.GetLength(1); col++)
                    {
                        stockRow[col] = tempBagelStock[row, col];
                    }
                    updateStockFile.WriteLine(String.Join(";", stockRow));
                }
                updateStockFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Close application
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
