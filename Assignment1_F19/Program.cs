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
                        int selfDividing = 1;
                        for (int temp = num; temp > 0; temp /= 10)
                        {
                            int dig = temp % 10;
                            if (dig == 0 || num % dig != 0)
                            {
                                selfDividing = 0;
                                break;
                            }
                        }
                        if (selfDividing == 1)
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

            public static void printSeries(int n)
            {
                try
                {
                    int print_count = 0;
                    int start_count = 1;
                    do
                    {
                        for (int i = 0; i < start_count; i++)
                        {
                            Console.Write("{0},", start_count);
                            print_count += 1;
                            if (print_count == n)
                            {
                                break;
                            }
                        }
                        start_count += 1;
                    } while (print_count < n);
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
                    // Write yo
                    int count = 0;
                    for (int i = 0; i < J.Length; i++)
                    {

                        for (int j = 0; j < S.Length; j++)
                        {
                            if (J[i] == S[j])
                            {
                                count = count + 1;
                            }

                        }
                        // returning the count of  stones you have whcih are also jewels.

                    }
                    return count;
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

                    List<int> common = new List<int>();

                    Array.Sort(a);
                    Array.Sort(b);

                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            if (a[i] == b[j])
                            {
                                common.Add(a[i]);
                            }
                        }
                    }

                    HashSet<int> hs = new HashSet<int>();

                    foreach (int n in common)
                    {
                        hs.Add(n);
                    }

                    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

                    foreach (int y in hs)
                    {
                        int m = y;
                        int sum = 0;
                        List<int> digits = new List<int>();
                        if (!hs.Contains(m - 1))
                            while (hs.Contains(m))
                            {
                                sum = sum + m;
                                digits.Add(m);
                                m++;
                            }
                        if (!map.ContainsKey(sum))
                        {
                            map.Add(sum, digits);
                        }
                    }

                    int max_sum = map.Keys.Max();
                    List<int> final_list = map[max_sum];
                    return final_list.ToArray();
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
                }

                return null; // return the actual array
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
