using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    interface IFactory
    {
        public IProduct createProduct(string type);
    }
}
