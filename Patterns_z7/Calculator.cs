using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_z7
{
  public   class Calculator
    {
        public int  Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }

        public int Dev(int a, int b)
        { 
        
            return a / b;
        }
        public double Sqrt(int a)
        {
            if (a < 0) throw new Exception();
            return Math.Sqrt(a);
        }
    }
}
