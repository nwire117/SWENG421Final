using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class OrderPending : AbstractOrderStatus
    {
        private Order parent;
        /*
        public OrderPending(Order parent)
        {
            this.parent = parent;
        }
        */
        public override AbstractOrderStatus nextState(int buttonEvent)
        {
            switch (buttonEvent)
            {
                case PENDING_EVENT:
                    return this;
                case PROCESSED_EVENT:
                    return processed;
                case SHIPPED_EVENT:
                    return shipped;
                default:
                    return this;
            }
        }

        public override void enter()
        {
            orderStatus = "Pending";
        }
    }
}
