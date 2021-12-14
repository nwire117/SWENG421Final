using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class Keyboard : IProduct, IOrderElement
    {
        private string name = "Keyboard";
        private double price = 18.99;
        private string color = "blue"; 
        public void addItem(IOrderElement item)
        {
            throw new NotImplementedException();
        }

        public void deleteItem(IOrderElement item)
        {
            throw new NotImplementedException();
        }

        public string getColor()
        {
            return color;
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }

        public void setColor(string color)
        {
            this.color = color;
        }
    }
}
