using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WarehouseManagement
{
    class ReadWriteLock
    {
        private int waitingReadLock = 0;
        private int currentReadLock = 0;
        private List<Thread> waitingWriteLock = new List<Thread>();
        private Thread writeLockedThread;

        public void readLock()
        {
            if (writeLockedThread != null)
            {
                waitingReadLock++;
                while(writeLockedThread != null)
                {
                    
                }
                waitingReadLock--;
            }
            currentReadLock++;
        }

        public void writeLock()
        {
            Thread thisThread;

            lock (this)
            {
                if(writeLockedThread == null && currentReadLock == 0)
                {
                    writeLockedThread = Thread.CurrentThread;
                    return;
                }
                thisThread = Thread.CurrentThread;
                waitingWriteLock.Add(thisThread);
            }

            lock (thisThread)
            {
                while (thisThread != writeLockedThread)
                {
                    
                }
            }

        }

        public void done()
        {

        }
    }
}
