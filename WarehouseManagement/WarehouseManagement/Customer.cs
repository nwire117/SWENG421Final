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
    public partial class Customer : Form
    {
        public Inventory inv;
        public Order order;
        bool customized = false;
        bool customcolor = false;
        bool decals = false;
        bool accessory = false;
        public string type;
        public IProduct prod;
        public Customer(Inventory inv, Order order)
        {
            InitializeComponent();
            this.inv = inv;
            this.order = order;
            listBox1.Items.Add("Mouse");
            listBox1.Items.Add("Keyboard");
            listBox1.Items.Add("Monitor");
            label5.Text = " ";
            label7.Text = "";
            comboBox3.Items.Add("Mouse pad");
            comboBox3.Items.Add("USB-C cable");
            comboBox3.Items.Add("Screen cleaner kit");
            comboBox2.Items.Add("Animal sticker set");
            comboBox2.Items.Add("Superhero sticker set");
            comboBox1.Items.Add("Yellow");
            comboBox1.Items.Add("Orange");
            comboBox1.Items.Add("Red");
            comboBox1.Items.Add("White");
            customize(customized);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            order.orderItems.RemoveAt(listBox2.SelectedIndex);
            listBox2.Items.Remove(listBox2.SelectedItem);   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customized = false;
            customize(customized);
            prod = inv.getItem(listBox1.SelectedItem.ToString());
            type = listBox1.SelectedItem.ToString();
            label7.Text = inv.getCount(type).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (customized)
            {
                customized = false;
            }
            else
            {
                customized = true;
            }
            customize(customized);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            accessory = true;
        }

        public void customize(bool custom)
        {
            comboBox1.Visible = custom;
            comboBox2.Visible = custom;
            comboBox3.Visible = custom;
            label8.Visible = custom;
            label9.Visible = custom;
            label10.Visible = custom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listing;
            addExtras();
            listing = prod.getName();
            if (customized)
            {
                listing += " (custom) ";
            }
            else
            {
                listing += " ";
            }
            listing += Math.Round(prod.getPrice(), 2);
            listBox2.Items.Add(listing);
            order.orderItems.Add(prod);
            prod = inv.getItem(listBox1.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customcolor = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            decals = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string item in listBox2.Items)
            {
                inv.removeItem(item);
            }
            label7.Text = inv.getCount(type).ToString();
            listBox2.Items.Clear();
            order.nextState(1);
            order.status = new OrderPending();
            order.status.enter();
            label5.Text = order.status.orderStatus;
        }

        public void addExtras()
        {
            if (customcolor)
            {
                prod = new CustomColorDecorator(prod);
                prod.setColor(comboBox1.SelectedItem.ToString());
            }
            if (decals)
            {
                prod = new DecalDecorator(prod);
            }
            if (accessory)
            {
                prod = new AccessoryDecorator(prod);
            }
        }
    }
}
