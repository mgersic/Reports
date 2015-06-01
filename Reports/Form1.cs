using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwndDataSet.Order_Details' table. You can move, or remove it, as needed.
            this.Order_DetailsTableAdapter.Fill(this.northwndDataSet.Order_Details);
            // TODO: This line of code loads data into the 'northwndDataSet.Orders' table. You can move, or remove it, as needed.
            this.OrdersTableAdapter.Fill(this.northwndDataSet.Orders);
            // TODO: This line of code loads data into the 'northwndDataSet.Customer_and_Suppliers_by_City' table. You can move, or remove it, as needed.
            this.Customer_and_Suppliers_by_CityTableAdapter.Fill(this.northwndDataSet.Customer_and_Suppliers_by_City);

            this.reportViewer1.RefreshReport();
        }
    }
}
