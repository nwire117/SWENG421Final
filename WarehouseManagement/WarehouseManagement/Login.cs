using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class Login : Form
    {
        public Inventory inv = new Inventory();
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form employee = new Employee(inv);
            employee.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form customer = new Customer(inv);
            customer.ShowDialog();
        }
    }
}
