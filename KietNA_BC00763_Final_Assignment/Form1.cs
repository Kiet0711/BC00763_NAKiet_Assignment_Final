using System.Diagnostics.Eventing.Reader;
using System.Runtime.ExceptionServices;

namespace KietNA_BC00763_Final_Assignment
{
    public partial class Form1 : Form
    {

        public List<Invoice> invoices = new List<Invoice>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {
            comboTypeOfCustumer.Items.Add("Household Custumer");
            comboTypeOfCustumer.Items.Add("Administrative Agency, Public Services");
            comboTypeOfCustumer.Items.Add("Production Units");
            comboTypeOfCustumer.Items.Add("Business Services");

            listWaterBill.View = View.Details;
            listWaterBill.Columns.Add("Custumer Name", 200);
            listWaterBill.Columns.Add("Custumer Type", 200);
            listWaterBill.Columns.Add("Last Month's Water Used", 200);
            listWaterBill.Columns.Add("This Month's Water Used", 200);
            listWaterBill.Columns.Add("Total Water Used", 200);
            listWaterBill.Columns.Add("Total Water Bill", 200);
        }

        private void comboTypeOfCustumer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String typeOfCustumer = comboTypeOfCustumer.Text;
            if (typeOfCustumer == "Household Custumer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }

        }

        private void buttonCaculator_Click(object sender, EventArgs e)
        {
            string customerName = txtCustumerName.Text.Trim();
            string customerType = comboTypeOfCustumer.Text.Trim();
            int numberOfPeople = 0;
            double lastMonthWaterUsed = 0;
            double thisMonthWaterUsed = 0;
            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name", "Vcalidation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customerType == "")
            {
                MessageBox.Show("Please enter customer type", "Vcalidation Error0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (customerType == "Household Custumer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || (numberOfPeople <= 0))
                {
                    MessageBox.Show("Please enter number of people", "Vcalidation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (!double.TryParse(txtLastMonthWaterUsed.Text, out lastMonthWaterUsed) || (lastMonthWaterUsed <= 0))
            {
                MessageBox.Show("Please enter last month water used", "Vcalidation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtThisMonthWaterUsed.Text, out thisMonthWaterUsed) || (thisMonthWaterUsed <= 0) || (thisMonthWaterUsed <= lastMonthWaterUsed))
            {
                MessageBox.Show("Please enter this month water used", "Vcalidation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var waterBill = Caculator(customerType, numberOfPeople, lastMonthWaterUsed, thisMonthWaterUsed);

            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(customerType.ToString());
            item.SubItems.Add(lastMonthWaterUsed.ToString());
            item.SubItems.Add(thisMonthWaterUsed.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            listWaterBill.Items.Add(item);

            Invoice invoice = new Invoice
            {
                CustomerName = customerName,
                CustomerType = customerType,
                LastMonthWaterUsed = lastMonthWaterUsed,
                ThisMonthWaterUsed = thisMonthWaterUsed,
                TotalWaterUsed = waterBill.Item1,
                WaterMoney = waterBill.Item2
            };
            invoices.Add(invoice);
        }
        private (double, double) Caculator(string custumerType, int numberOfPeople, double lastMonthWaterUsed, double thisMonthWaterUsed)
        {
            double consumption = (thisMonthWaterUsed - lastMonthWaterUsed);
            double waterMoney = 0;
            double firstBill = 0;
            if (custumerType == "Household Custumer")
            {
                double avgPeople = consumption / numberOfPeople;
                if (numberOfPeople < 10)
                {
                     firstBill = avgPeople * 5793 * numberOfPeople;
                }
                else if (numberOfPeople < 20)
                {
                     firstBill = (10 * 5793 * numberOfPeople) + ((avgPeople - 20) * 7052 * numberOfPeople);
                }
                else if (numberOfPeople < 30)
                {
                     firstBill = (10 * 5793 * numberOfPeople) + (10 * 7052 * numberOfPeople) + ((avgPeople - 30) * 8699 * numberOfPeople);
                }
                else
                {
                   firstBill = (10 * 5793 * numberOfPeople) + (10 * 7052 * numberOfPeople) + (10 * 8699 * numberOfPeople) + ((avgPeople - 30) * 15929 * numberOfPeople);
                }
                waterMoney = (firstBill + (firstBill * 0.1) + (firstBill * 0.1));
            }
            else if (custumerType == "Administrative Agency, Public Services")
            {
                firstBill = 9950 * consumption;
                waterMoney = firstBill + (firstBill * 0.1) + (firstBill * 0.1);
            }
            else if (custumerType == "Production Units")
            {
                 firstBill = 11615 * consumption;
                waterMoney = firstBill + (firstBill * 0.1) + (firstBill * 0.1);
            }
            else if (custumerType == "Business Services")
            {
                firstBill = 22068 * consumption;
                waterMoney = firstBill + (firstBill * 0.1) + (firstBill * 0.1);
            }
            return (consumption, waterMoney);
        }
        private void txtSearch_TextChaged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            listWaterBill.Items.Clear();
            bool foundResult = false;

            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {
                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterUsed.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterUsed.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    listWaterBill.Items.Add(item);
                }

            }
            else
            {

                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName == search)
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterUsed.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterUsed.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        listWaterBill.Items.Add(item);

                    }

                }
            }
            if (!foundResult)
            {
                ListViewItem item = new ListViewItem("No results found.");
                listWaterBill.Items.Add(item);
            }
        }

        private void comboSort_SelectedIndexChanged(object sender, EventArgs e)
        {



            string sortBy = comboSort.Text.Trim();
            switch (sortBy)
            {
                case "Small to Large":
                    invoices = invoices.OrderBy(inv => inv.WaterMoney).ToList();
                    break;
                case "Large to Small":
                    invoices = invoices.OrderByDescending(inv => inv.WaterMoney).ToList();
                    break;
                default:
                    break;
            }

            listWaterBill.Items.Clear();
            foreach (Invoice invoice in invoices)
            {
                ListViewItem item = new ListViewItem(invoice.CustomerName);
                item.SubItems.Add(invoice.LastMonthWaterUsed.ToString());
                item.SubItems.Add(invoice.ThisMonthWaterUsed.ToString());
                item.SubItems.Add(invoice.WaterMoney.ToString());
                listWaterBill.Items.Add(item);
            }
        }

        private void btPrintBill_Click(object sender, EventArgs e)
        {
            if (listWaterBill.SelectedItems.Count > 0)
            {
                listWaterBill.Items[0].Selected = true;
                ListViewItem selectedItem = listWaterBill.SelectedItems[0];
                string customerName = selectedItem.SubItems[0].Text;
                string customerType = selectedItem.SubItems[1].Text;
                double lastMonthWaterUsed = double.Parse(selectedItem.SubItems[2].Text);
                double thisMonthWaterUsed = double.Parse(selectedItem.SubItems[3].Text);
                double totalWaterUsed = double.Parse(selectedItem.SubItems[4].Text);
                double waterMoney = double.Parse(selectedItem.SubItems[5].Text);
                Invoice invoice = new Invoice
                {
                    CustomerName = customerName,
                    CustomerType = customerType,
                    LastMonthWaterUsed = lastMonthWaterUsed,
                    ThisMonthWaterUsed = thisMonthWaterUsed,
                    WaterMoney = waterMoney,
                };
                Form2 form2 = new Form2(invoice);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a bill to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    
    }

    public class Invoice
    {
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public double LastMonthWaterUsed { get; set; }
        public double ThisMonthWaterUsed { get; set; }
        public double TotalWaterUsed { get; set; }
        public double WaterMoney { get; set; }
     
    }
}
