using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Practice
{
    internal class PurchadeList
    {
        public int[] ShopkeeperList()
        {
            int[] arr = { 5, 5, 4, 7, 4, 1, 11 };
            int n = arr.Length;
            int once = 0;
            int morethanone = 0;
            Dictionary<int, int> price = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (price.ContainsKey(i))
                {
                    price[i]++;
                }
                else
                {
                    price[i] = 1;
                }
            }
            foreach (int key in price.Keys)
            {
                if (price[key] == 1)
                {
                    once = key;
                    break;
                }
            }
            foreach (int key in price.Keys)
            {
                if (price[key] > 1)
                {
                    morethanone = key;
                    break;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                bool status = false;
                foreach (int key in price.Keys)
                {
                    if (price[key] != 1)
                    {
                        status = true;
                        break;
                    }
                }
                Console.WriteLine(once);
                if (!status)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(morethanone);
                }
            }
            int[] result = { once, morethanone };
            return result;
        }
    }

}
