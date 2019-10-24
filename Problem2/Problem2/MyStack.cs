using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class myStack
    {
        private int[] Buffet;
        private int Top;      
        public myStack(int n)
        {       
            Buffet = new int[n];
            Top = -1;
        }
        public void push(int item)
        {
            Buffet[Top+1] = item;
            Top++;
        }
        public int pop()
        {
            return Buffet[Top--];
        }
        public int Count()
        {         
            return Top+1;
        }
        public int peek()
        {
            return Buffet[Top];
        }
        public void clear()
        {
            this.Top = -1;
        }
    }
}