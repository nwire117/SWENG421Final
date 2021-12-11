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

        DecalDecorator(IProduct p)
        {
            this.wrappedProduct = p;
        }

        public void addDecal(string decal)
        {

        }
    }
}
