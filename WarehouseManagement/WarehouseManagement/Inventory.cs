using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class Inventory
    {
        private List<IProduct> product1 = new List<IProduct>();
        private List<IProduct> product2 = new List<IProduct>();
        private List<IProduct> product3 = new List<IProduct>();
        private ReadWriteLock lockManager = new ReadWriteLock();

        public int getCount(List<IProduct> list)
        {
            int count = 0;

            return count;
        }

        public void viewItems(List<IProduct> list)
        {

        }

        public void addItem(IOrderElement item)
        {

        }

        public void removeItem(IOrderElement item)
        {

        }
    }
}
