using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caKisi2Nomor2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ","");
            char[] kata1 = input.ToLower().ToCharArray();
            char tmpg = 'a';
            for (int i = 0; i < kata1.Length; i++)
            {
                if (i<kata1.Length-1)
                {
                    for (int j = i+1; j < kata1.Length; j++)
                    {
                        if (kata1[i]==kata1[j])
                        {
                            tmpg = kata1[j];
                            for (int k = j; k >= i+2; k--)
                            {
                                kata1[k] = kata1[k-1];
                            }
                            kata1[i + 1] = tmpg;
                        }
                    }
                }
            }
            foreach (var item in kata1)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
