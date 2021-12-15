using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public abstract class AbstractOrderStatus
    {
        public static OrderPending pending = new OrderPending();
        public static OrderProcessed processed = new OrderProcessed();
        public static OrderShipped shipped = new OrderShipped();

        public const int PENDING_EVENT = 1;
        public const int PROCESSED_EVENT = 2;
        public const int SHIPPED_EVENT = 3;

        public string orderStatus;

        abstract public AbstractOrderStatus nextState(int buttonEvent);
        abstract public void enter();
    }
}
