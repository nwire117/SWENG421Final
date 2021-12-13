using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class ReadWriteLock
    {
        private int waitingReadLock;
        private int currentReadLock;
        private List<IProduct> waitingWriteLock = new List<IProduct>();

        public void readLock()
        {

        }

        public void writeLock()
        {

        }

        public void done()
        {

        }
    }
}
