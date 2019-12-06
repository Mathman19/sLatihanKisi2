using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caKisi2Nomor3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", "");
            char[] kata = input.ToLower().ToCharArray();
            int tmpg = 0;
            for (int i = 0; i < kata.Length-1; i++)
            {
                for (int j = i+1; j < kata.Length; j++)
                {
                    if (kata[i]==kata[j])
                    {
                        tmpg += 1;
                        break;
                    }
                }
            }
            int jumlah = kata.Length - tmpg;
            Console.WriteLine("Jumlah kata: " + jumlah);
        }
    }
}
