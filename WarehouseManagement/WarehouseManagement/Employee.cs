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
    public partial class Employee : Form
    {
        public string type = "";
        public Inventory inv;
        Factory fact = new Factory();
        public Employee(Inventory inv)
        {
            InitializeComponent();
            label6.Text = " ";
            listBox1.Items.Add("Mouse");
            listBox1.Items.Add("Keyboard");
            listBox1.Items.Add("Monitor");
            this.inv = inv;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = listBox1.SelectedItem.ToString();
            label6.Text = inv.getCount(type).ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemcount = (int)numericUpDown1.Value;
            for(int i = 0; i < itemcount; i++)
            {
                IProduct p = fact.createProduct(type);
                inv.addItem(p);
            }
            label6.Text = inv.getCount(type).ToString();
        }
    }
}
