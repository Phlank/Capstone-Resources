using System;
using System.Collections.Generic;
using System.Text;

namespace BackendProject.Handlers
{
    public class FibonacciHandler
    {
        public static int ProcessSum(params int[] values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += Fibonacci(value);
            }
            return sum;
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
