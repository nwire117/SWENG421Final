using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class Mouse : IProduct, IOrderElement
    {
        private string name = "Mouse";
        private double price = 12.99;
        private string color = "green";
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
