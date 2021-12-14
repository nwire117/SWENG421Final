using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class CustomColorDecorator : AbstractProductDecorator
    {
       private IProduct wrappedProduct;
       public double price;
        private string name;
        private string color;

        public CustomColorDecorator(IProduct p)
        {
            this.wrappedProduct = p;
            this.price = wrappedProduct.getPrice() + 5.99;
            this.name = wrappedProduct.getName();
            this.color = wrappedProduct.getColor();
        }

        public override void setColor(string color)
        {
            wrappedProduct.setColor(color);
        }

        public override string getName()
        {
            return name;
        }

        public override double getPrice()
        {
            return price;
        }
    }
}
