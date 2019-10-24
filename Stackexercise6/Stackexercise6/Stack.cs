using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackexercise6
{
   public class Stack
    {
        private string[] Buffer;
        private int Top;
        private int v;
       //có thể dùng string ...
        public Stack(int size)
        {
            Buffer = new string[size];
             Top =- 1;
        }
       
        public void Push(string v)
        {
           Buffer[Top+1] = v;
            Top++;
            //Buffer[Top++] = v; //sai
            //Buffer[++Top] = v; //dung
        }
        public string pop()
        {
           string v = Buffer[Top];
            Top--;
            return v;
        }
        public string peek()
        {
           string v = Buffer[Top];
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
