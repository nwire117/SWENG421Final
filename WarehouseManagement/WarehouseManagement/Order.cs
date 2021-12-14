using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class Order : CompositeOrder
    {

        OrderPending pending;
        OrderProcessed processed;
        OrderShipped shipped;
        public int pendingEvent;
        public int processedEvent;
        public int shippedEvent;

        public void purchase()
        {

        }

        public void cancelOrder()
        {

        }

        public Order nextState(int evnt)
        {
            Order newOrder = new Order();
            return newOrder;
        }
    }
}
