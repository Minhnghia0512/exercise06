using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class MyQueue
    {
        private int[] Buffer;
        private int Top;
        private int last;
        public MyQueue(int n)
        {
            Buffer = new int[n];
            Top = -1;
            last = 0;
        }
        public void Enqueue(int item)
        {
            Buffer[Top+1] = item;
            Top++;
        }
        public int Dequeue()
        {
            return Buffer[last++];
        }
        public int Count()
        {
            return Top +1 ;
        }
        public int Peek()
        {
            return Buffer[last];
        }
    }
}
