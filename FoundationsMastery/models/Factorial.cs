using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery.models
{
    class Factorial : IFactorial
    {
        public Factorial(int arg)
        {
            int factor = arg;
        }

        int factor { get; set; }

        public int Iterative(int n)
        {
            var x = 1;
            for (var i = 1; i <= n; i++)
            {
                x *= i;
            }

            return x;
        }

        public int Recursive(int n)
        {
            int x;
            x = n * Iterative(n - 1);
            return x;
        }
    }
}
