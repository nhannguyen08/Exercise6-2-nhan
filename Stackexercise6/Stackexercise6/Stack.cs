using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackexercise6
{
   public class Stack
    {
        private int[] Buffer;
        private int Top;
        private int v;
        public Stack(int size)
        {
            Buffer = new int[size];
            Top -= 1;
        }
        public void Push(int v)
        {
           Buffer[Top+1] = v;
            Top++;
            
        }
        public int pop()
        {
            v = Buffer[Top];
            Top--;
            return v;
        }
        public int peek()
        {
            v = Buffer[Top];
            return v;
        }
        public void Clear()
        {
           
            Top =- 1;
        }
        public int Count()
        {
         
            return Top + 1;
        }

    }
}
