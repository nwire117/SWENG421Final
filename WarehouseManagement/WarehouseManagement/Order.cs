using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class Order : CompositeOrder
    {
        public Inventory inventory = new Inventory();
        OrderPending pending = new OrderPending();
        OrderProcessed processed = new OrderProcessed();
        OrderShipped shipped = new OrderShipped();
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
