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
        public Order order;
        Factory fact = new Factory();
        public Employee(Inventory inv, Order order)
        {
            InitializeComponent();
            label6.Text = " ";
            listBox1.Items.Add("Mouse");
            listBox1.Items.Add("Keyboard");
            listBox1.Items.Add("Monitor");
            listBox2.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
            this.inv = inv;
            this.order = order;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = listBox1.SelectedItem.ToString();
            label6.Text = inv.getCount(type).ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!type.Equals(""))
            {
                int itemcount = (int)numericUpDown1.Value;
                for (int i = 0; i < itemcount; i++)
                {
                    IProduct p = fact.createProduct(type);
                    inv.addItem(p);
                }
                label6.Text = inv.getCount(type).ToString();
            } 
            numericUpDown1.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!listBox2.Visible)
            {
                listBox2.Visible = true;
                button2.Visible = true;
            }
            else
            {
                listBox2.Visible = false;
                button2.Visible = false;
            }

            foreach(IProduct p in order.orderItems)
            {
                listBox2.Items.Add(p.getName() + " " + Math.Round(p.getPrice(), 2));
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            order.status.nextState(2);
            order.status.enter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            listBox2.Items.Clear();
            order.orderItems.Clear();
            order.status.nextState(3);
            order.status.enter();
        }
    }
}
