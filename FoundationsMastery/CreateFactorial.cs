using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.models;

namespace FoundationsMastery
{
    class CreateFactorial : Factorial
    {
        public override int Iterative(int n)
        {
            if (n < 1)
            {
                throw new InvalidOperationException();
            }
            var x = 1;
            for (var i = 1; i <= n; i++)
            {
                x *= i;
            }

            return x;
        }
    }
}
