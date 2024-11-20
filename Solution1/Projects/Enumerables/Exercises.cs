using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Enumerables
{
    public class Exercises
    {


        public static void Run()
        {
            Console.WriteLine(perimeter(7));


        }


        public static BigInteger perimeter(BigInteger n)
        {
            BigInteger limit = n + 1;
            BigInteger counter = 2;
            BigInteger sum = 8;
            BigInteger x = 1, y = 1;
            for (int i = 3; i <= limit; i++)
            {
                if (counter == limit) break;
                x += y;
                sum += 4 * x;
                counter++;
                if (counter == limit) break;
                y += x;
                sum += 4 * y;
                counter++;
            }

            return sum;
        }





    }
}
