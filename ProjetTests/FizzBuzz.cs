using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetTests
{
    public class FizzBuzz
    {
        public object FizzBuzzTest(int v)
        {
            if (v % 15 == 0)
            {
                return "FizzBuzz";
            } 

            else if (v % 5 == 0)
            {
                return "Buzz";
            }

            else if (v % 3 == 0)
            {
                return "Fizz";
            }

            return v;
        }
    }
}
