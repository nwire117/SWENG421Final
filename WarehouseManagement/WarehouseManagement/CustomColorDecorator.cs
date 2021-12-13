using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class CustomColorDecorator : AbstractProductDecorator
    {
       private IProduct wrappedProduct;
       public double price;

        CustomColorDecorator(IProduct p)
        {
            this.wrappedProduct = p;
            price = wrappedProduct.getPrice() + 5.99;
        }

        public void setColor(string color)
        {
            wrappedProduct.setColor(color);
        }
    }
}
