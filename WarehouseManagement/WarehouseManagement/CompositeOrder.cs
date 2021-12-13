using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class CompositeOrder : IProduct, IOrderElement
    {
        public List<IOrderElement> orderItems = new List<IOrderElement>();

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
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }

        public double getPrice()
        {
            throw new NotImplementedException();
        }

        void IProduct.setColor(string color)
        {
            throw new NotImplementedException();
        }
    }
}
