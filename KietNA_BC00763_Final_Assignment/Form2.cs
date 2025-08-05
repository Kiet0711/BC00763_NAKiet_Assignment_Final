using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KietNA_BC00763_Final_Assignment.Form1;

namespace KietNA_BC00763_Final_Assignment
{
    public partial class Form2 : Form
    {
        public Form2(Invoice invoice)
        {
            InitializeComponent();
            printCustomerName.Text = invoice.CustomerName;
            printTypeOfCustomer.Text = invoice.CustomerType;
            printLastMonthWaterUsed.Text = invoice.LastMonthWaterUsed.ToString();
            printThisMonthWaterUsed.Text = invoice.ThisMonthWaterUsed.ToString();
            printTotalBill.Text = invoice.WaterMoney.ToString();
        }

        private List<Invoice> invoices = new List<Invoice>();

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
