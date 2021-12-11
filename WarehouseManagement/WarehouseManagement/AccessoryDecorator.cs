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

        AccessoryDecorator(IProduct p)
        {
            this.wrappedProduct = p;
        }

        public void addAccessory(string accessory)
        {

        }

    }
}
