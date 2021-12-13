using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class Factory: IFactory
    {
        public IProduct createProduct(string type)
        {
            Type t = Type.GetType("WarehouseManagement." + type);
            Object o = Activator.CreateInstance(t);
            IProduct p = (IProduct)o;

            return p;
        }
    }
}
