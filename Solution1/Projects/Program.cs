using System;
using Projects.Library_Mangement_System_Applying_Concepts_;

namespace Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            //App.Run();
            //var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
            //foreach (int i in pp)
            //{
            //    Console.WriteLine(IsPerfectPower(i));
            //}
                 Console.WriteLine(IsPerfectPower(216));
                //Console.WriteLine(IsPerfectPower(243));

        }

        public static (int, int)? IsPerfectPower(int n)
        {
            int k;
            double m;
            if (n == 1 || n == 2 || n == 3) return null;

            for (k = 2; k <= n; k++)
            {
                m = Math.Pow(n, 1.0 / (double)k);
                if (m % (int)m == 0 || m % (int)m == .999999999)
                    return ((int)m, k);
            }

            return null;
        }

    }
}
