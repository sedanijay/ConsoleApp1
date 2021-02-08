using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int min(int x,
                       int y, int z)
        {
            if (x < y) {
                return ((x < z) ? x : z);
            }
            else {
                return ((y < z) ? y : z);
            }
        }

        
        static int minCost(int[,] cost,
                           int m, int n)
        {
            
            if (n < 0 || m < 0)
                return int.MaxValue;
            else if (m == 0 && n == 0)
                return cost[m, n];
            else
                return cost[m, n] +
                       min(minCost(cost, m - 1, n - 1),
                       minCost(cost, m - 1, n),
                       minCost(cost, m, n - 1));
        }

        public static void Main()
        {

            int[,] cost = {{5,9,7,3,4},
                    {6,3,7,1,9},
                    {5,2,8,3,7},
                    {2,7,9,2,2},
                    {4,8,3,5,1}};

            Console.Write(minCost(cost, 0, 4));
            Console.Read();
        }
    }
    

}

