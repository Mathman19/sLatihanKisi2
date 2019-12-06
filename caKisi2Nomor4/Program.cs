using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caKisi2Nomor4
{
    class Program
    {
        static void Main(string[] args)
        {
            int angka1 = int.Parse(Console.ReadLine());
            int angka2 = int.Parse(Console.ReadLine());
            kpk(angka1, angka2);
        }

        public static void kpk(int a, int b)
        {
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < a*b; i++)
            {
                num1 += a ;
                num2 += b;
                if (num1 == num2)
                {
                    Console.WriteLine("ketemu");
                }
            }
        }
    }
}
