using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NUnit_1
{
    public class Calculator 
    { 
        public int Add(int a, int b)
        { 
            int x = a + b;
            return x;
        }
        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;
        }
        public int Divide(int a, int b)
        {
            int x = a / b;
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
