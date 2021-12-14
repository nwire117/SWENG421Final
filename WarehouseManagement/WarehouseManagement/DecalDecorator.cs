using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class DecalDecorator : AbstractProductDecorator
    {
        private IProduct wrappedProduct;
        public double price;
        public string decal;
        private string name;
        private string color;

        public DecalDecorator(IProduct p)
        {
            this.wrappedProduct = p;
            this.price = wrappedProduct.getPrice() + 2.99;
            this.name = wrappedProduct.getName();
            this.color = wrappedProduct.getColor();
        }

        public void addDecal(string decal)
        {
            this.decal = decal;
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
