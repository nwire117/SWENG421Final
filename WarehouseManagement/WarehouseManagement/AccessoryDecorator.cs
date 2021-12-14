using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class AccessoryDecorator : AbstractProductDecorator
    {
        private IProduct wrappedProduct;
        public double price;
        private string name;
        private string color;

        public AccessoryDecorator(IProduct p)
        {
            this.wrappedProduct = p;
            this.price = wrappedProduct.getPrice() + 9.99;
            this.name = wrappedProduct.getName();
            this.color = wrappedProduct.getColor();
        }

        public void addAccessory(string accessory)
        {

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
