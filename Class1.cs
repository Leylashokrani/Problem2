using System;
using System.Collections.Generic;
using System.Text;

namespace Explanation1
{
    internal class Class1
    {


        // function that will
        // calculate the factorial
        static long factorial(int N)
        {
            int result = 1;
            while (N > 0)
            {
                result = result * N;
                N--;
            }
            return result;
        }

        static long countWays(int N)
        {
            long total = factorial(N + N);
            long total1 = factorial(N);
            return (total / total1) / total1;
        }

        // Driver code
        public static void Main(String[] args)
        {
            int N = 5;
            Console.WriteLine("Ways = " + countWays(N));
        }
    }
}



//namespace Explanation1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] temp = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2 ,1,3};
//            int max = temp[0];
//            int indexLast = 1;
//            int sum = 0;
//            for (int i = 1; i < temp.Length; i++)
//            {
//                if (temp[i - 1] < temp[i])
//                {
//                    for (int j = indexLast; j < i; j++)
//                    {
//                        if (temp[i] > temp[j] && temp[indexLast] > temp[j])
//                        {
//                            if (temp[i] > temp[indexLast])
//                            {
//                                sum = sum + (temp[indexLast] - temp[j]);
//                                temp[j] = temp[j] + (temp[indexLast] - temp[j]);
//                            }
//                            else
//                            { 
//                                sum = sum + (temp[i] - temp[j]);
//                                temp[j] = temp[j] + (temp[i] - temp[j]);

//                            }

//                        }

//                    }
//                }
//                    if (max <= temp[i])
//                {

//                    indexLast = i;
//                    max = temp[i];
//                }

//            }

//            Console.WriteLine("Hello World!",sum);
//        }
//    }
//}
