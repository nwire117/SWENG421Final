using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public abstract class AbstractProductDecorator : IProduct, IOrderElement

    {
        private IProduct wrappedProduct;
        private string name;
        private double price;
        private string color;

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

        public virtual string getName()
        {
            return name;
        }

        public virtual double getPrice()
        {
            return price;
        }

        public virtual void setColor(string color)
        {
            wrappedProduct.setColor(color);
        }
    }
}
