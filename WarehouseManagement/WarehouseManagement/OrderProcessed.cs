using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class OrderProcessed: AbstractOrderStatus
    {
        private Order parent;

        public override AbstractOrderStatus nextState(int buttonEvent)
        {
            switch (buttonEvent)
            {
                case PENDING_EVENT:
                    return pending;
                case PROCESSED_EVENT:
                    return this;
                case SHIPPED_EVENT:
                    return shipped;
                default:
                    return this;
            }
        }


        public override void enter()
        {
            orderStatus = "Processed";
        }
        
    }
}
