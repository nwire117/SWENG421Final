using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    public class Inventory
    {
        private List<IProduct> mouse = new List<IProduct>();
        private List<IProduct> keyboard = new List<IProduct>();
        private List<IProduct> monitor = new List<IProduct>();
        private ReadWriteLock lockManager = new ReadWriteLock();

        public int getCount(string list)
        {
            int count = 0;
            if (list.Equals("Mouse"))
            {
                count = mouse.Count();
            }
            if (list.Equals("Monitor"))
            {
                count = monitor.Count();
            }
            if (list.Equals("Keyboard"))
            {
                count = keyboard.Count();
            }
            return count;
        }

        public void viewItems(List<IProduct> list)
        {

        }

        public void addItem(IProduct item)
        {
            if (item is Monitor)
            {
                monitor.Add(item);
            }
            if(item is Keyboard)
            {
                keyboard.Add(item);
            }
            if(item is Mouse)
            {
                mouse.Add(item);
            }
        }

        public IProduct getItem(string item)
        {
            if (item.Equals("Monitor"))
            {
                return monitor[0];
            }
            if (item.Equals("Keyboard"))
            {
                return keyboard[0];
            }
            if (item.Equals("Mouse"))
            {
                return mouse[0];
            }
            else
            {
                return null;
            }

     
        }

        public void removeItem(string item)
        {
            if (item.Contains("Monitor"))
            {
                monitor.RemoveAt(0);
            }
            if (item.Contains("Keyboard"))
            {
               keyboard.RemoveAt(0);
            }
            if (item.Contains("Mouse"))
            {
                mouse.RemoveAt(0);
            }
        }
    }
}
