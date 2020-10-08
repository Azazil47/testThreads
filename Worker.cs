using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadTest2
{
    class Worker
    {
        private bool _cancelled = false;

        public void Cancel()
        {
            _cancelled = true;
        }

        public void Work()
        {
            for (int i = 0; i < 100; i++)
            {
                if (_cancelled)
                {
                    break;
                }
                Thread.Sleep(50);
                ProcessChanged(i);
            }
            WorkComplite(_cancelled);
        }

        public event Action<int> ProcessChanged;
        public event Action<bool> WorkComplite;
    }
}
