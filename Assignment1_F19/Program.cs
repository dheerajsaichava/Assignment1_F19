using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        { }
    }

namespace Assignment1_F19
    {
        class Program
        {
            static void Main(string[] args)
            {
                int a = 1, b = 22;
                printSelfDividingNumbers(a, b);

                int n2 = 5;
                printSeries(n2);

                int n3 = 5;
                printTriangle(n3);

                int[] J = new int[] { 1, 3 };
                int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
                int r4 = numJewelsInStones(J, S);
                Console.WriteLine(r4);

                int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
                int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
                int[] r5 = getLargestCommonSubArray(arr1, arr2);
                Console.WriteLine(r5);

                solvePuzzle();
            }

            public static void printSelfDividingNumbers(int x, int y)
            {
                try
                {

                    Console.Write("Enter the first number:");
                    int i = int.Parse(Console.ReadLine());
                    Console.Write("Enter the next number:");
                    int j = int.Parse(Console.ReadLine());
                    for (int num = i; num <= j; num++)
                    {
                        int selfdiv = 1;
                        for (int temp = num; temp > 0; temp /= 10)
                        {
                            int dig = temp % 10;
                            if (dig == 0 || num % dig != 0)
                            {
                                selfdiv = 0;
                                break;
                            }
                        }
                        if (selfdiv == 1)
                        {
                            Console.Write("{0},", num);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
                }
            }

            public static void printSeries(int x)
            {
                try
                {
                    int print_cnt = 0;
                    int start_cnt = 1;
                    do
                    {
                        for (int i = 0; i < start_cnt; i++)
                        {
                            Console.Write("{0},", start_cnt);
                            print_cnt += 1;
                            if (print_cnt == i)
                            {
                                break;
                            }
                        }
                        start_cnt += 1;
                    } while (print_cnt < x);
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing printSeries()");
                }
            }

            public static void printTriangle(int n)
            {
                try
                {
                    Console.WriteLine("Enter the number of rows :");
                    int i = int.Parse(Console.ReadLine());
                    for (int x = i; x >= 1; x--)
                    {
                        for (int y = i; y > x; y--)
                        {
                            Console.Write("  ");
                        }
                        for (int z = 1; z < 2 * x; z++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing printTriangle()");
                }
            }

            public static int numJewelsInStones(int[] J, int[] S)
            {
                try
                {
                    
                    int c = 0;
                    for (int i = 0; i < J.Length; i++)
                    {

                        for (int j = 0; j < S.Length; j++)
                        {
                            if (J[i] == S[j])
                            {
                                c = c + 1;
                            }

                        }
                       

                    }
                    return c;
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing numJewelsInStones()");
                }

                return 0;
            }

            public static int[] getLargestCommonSubArray(int[] a, int[] b)
            {
                try
                {

                    List<int> Common = new List<int>();

                    Array.Sort(a);
                    Array.Sort(b);

                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            if (a[i] == b[j])
                            {
                                Common.Add(a[i]);
                            }
                        }
                    }

                    HashSet<int> h = new HashSet<int>();

                    foreach (int n in Common)
                    {
                        h.Add(n);
                    }

                    Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

                    foreach (int y in h)
                    {
                        int j = y;
                        int m = 0;
                        List<int> dig = new List<int>();
                        if (!h.Contains(j - 1))
                            while (h.Contains(j))
                            {
                                m = m + j;
                                dig.Add(j);
                                j++;
                            }
                        if (!dict.ContainsKey(m))
                        {
                            dict.Add(m, dig);
                        }
                    }

                    int max = dict.Keys.Max();
                    List<int> result = dict[max];
                    return result.ToArray();
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                }

                return null; // 
            }

            public static void solvePuzzle()
            {
                try
                {
                   /*U=1,B=2,E=7,R=4,C=9,O=6,L=3,N=0 */
                    
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing solvePuzzle()");
                }
            }
        }
    }

}
