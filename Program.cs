using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array =
       {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };
            int[] arr = Snail(array);
            for (int u = 0; u < arr.Length; u++)
                Console.Write("{0}\t",arr[u]);
            Console.ReadKey();
        }
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 0)
            {
                int[] mas = new int[0];
                return mas;
            }
            else
            {

                int it = 0;
                List<int> res = new List<int>();
                int n = array[0].Length;
                int N = n * n;
                int i = 0, n1 = n;
                int l = n - 1, n2 = n;
                int m = n - 1, n3 = n - 2;
                int s = 0, n4 = n - 2;
                while (it < N)
                {
                    //*****************************************************
                    
                  
                        for (int j = i; j < n1; j++)
                        {
                            if (it < N)
                            {
                                res.Add(array[i][j]);
                                it++;
                            }
                        }
                        i++;
                        n1--;
                    
                    //********************************************
                        for (int k = n - l; k < n2; k++)
                        {
                            if (it < N)
                            {
                                res.Add(array[k][l]);
                                it++;
                            }
                        }
                        l--;
                        n2--;
                    
                    //*******************************************************
                        for (int o = n3; o >= n - (m + 1); o--)
                        {

                            if (it < N)
                            {
                                res.Add(array[m][o]);
                                it++;
                            }
                        }
                        m--;
                        n3--;               
                    //**********************************************************
                        for (int p = n4; p >= n - (n4+1); p--)
                        {
                            if (it < N)
                            {
                                res.Add(array[p][s]);
                                it++;
                            }
                        }
                        s++;
                        n4--;                   
                    //*******************************************************
                }
                int[] r = new int[N];
                for (int u = 0; u < N; u++)
                    r[u] = res[u];
                return r;
            }
            //***************************************************************
        }
    }
}
