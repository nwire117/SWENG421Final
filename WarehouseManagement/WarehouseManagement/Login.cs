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
        public Order order = new Order();
        public Login()
        {
            InitializeComponent();
            for(int i = 0; i< 3; i++)
            {
                inv.addItem(new Monitor());
            }
            for (int i = 0; i < 5; i++)
            {
                inv.addItem(new Mouse());
            }
            for (int i = 0; i < 4; i++)
            {
                inv.addItem(new Keyboard());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form employee = new Employee(inv, order);
            employee.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form customer = new Customer(inv, order);
            customer.ShowDialog();
        }
    }
}
