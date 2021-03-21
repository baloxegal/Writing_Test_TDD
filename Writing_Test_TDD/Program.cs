using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Test_TDD
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static int Min(int a, int b, int c)
        {
            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
        public static float Avg(int a, int b, int c)
        {
            float avg = ((float)a + b + c) / 3;
            return avg;
        }
        public static float Div(float n1, float n2)
        {
            if (n2 == 0.0)
                throw new DivideByZeroException("Error!!!!");
            return n1 / n2;
        }
    }
}
