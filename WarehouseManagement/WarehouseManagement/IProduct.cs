using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public interface IProduct
    {
        public string getName();
        public double getPrice();
        public string getColor();

        public void setColor(string color);
    }
}
