using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetOddInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = oddNumbers(_l, _r);
            Console.WriteLine("The odd numbers between "  + _l.ToString() + " and  " + _r.ToString() + " are: ");
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
                
            Console.Read();
        }
        static int[] oddNumbers(int l, int r)
        {
            int[] cur = new int[r];
            cur = Enumerable.Range(l, r).ToArray();
            //int length = cur.Count();
            int[] values = new int[r];
            for (int i = 0; i <= r; i++)
            {
                if (l <= r)
                {
                    values[i] = l;
                    l++;
                }
            }
            var oddnumbers = values.Where(x => x % 2 != 0).ToArray();
            int[] arr = new int[(int)oddnumbers.Count()];

            return oddnumbers;
        }
    }
}
