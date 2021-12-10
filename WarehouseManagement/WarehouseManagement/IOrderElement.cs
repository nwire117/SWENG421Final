using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    interface IOrderElement
    {
        public void addItem(IOrderElement item);
        public void deleteItem(IOrderElement item);
    }
}
