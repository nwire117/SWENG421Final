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

        CustomColorDecorator(IProduct p)
        {
            this.wrappedProduct = p;
        }

        public void setColor()
        {

        }
    }
}
