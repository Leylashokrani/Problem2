using System;
using System.IO;
using System.Net;
//class MainClass
//{
//    static void Main()
//    {
//        int output = 0;
//        WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/age-counting");
//        WebResponse response = request.GetResponse();
//        String body = String.Empty;
//        using (var stream = response.GetResponseStream())
//        {
//            using (var reader = new StreamReader(stream))
//            {
//                body = reader.ReadToEnd();
//                string temp = body.Split(':')[1];
//                var temp1 = temp.Remove(temp.Length - 2).Split(',');

//                for (int i = 0; i < temp1.Length; i++)
//                {
//                    var temp2 = temp1[i].Split('=');
//                    if (temp2[0].Trim() == "age")
//                    {
//                        if (Convert.ToInt16(temp2[1]) >= 50)
//                        {
//                            output++;
//                        }
//                    }
//                }
//            }
//        }

//       encode("26wzuk4t70", output);
//        response.Close();
//    }
//    static void encode(String s, int k)
//    {

//        // changed string
//        String newS = "";

//        // iterate for every characters
//        for (int i = 0; i < s.Length; ++i)
//        {
//            // ASCII value
//            int val = s[i];
//            // store the duplicate
//            int dup = k;

//            // if k-th ahead character exceed 'z'
//            if (val + k > 122)
//            {
//                k -= (122 - val);
//                k = k % 26;

//                newS += (char)(96 + k);
//            }
//            else
//            {
//                newS += (char)(96 + k);
//            }

//            k = dup;
//        }

//        // print the new string
//        Console.Write(newS);
//    }
//}


namespace Explanation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] temp = new int[100];

            Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
            Console.Write("------------------------------------------------------------------------\n");

            Console.Write("Input the number of elements to store in the array :");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} number of elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                temp[i] = Convert.ToInt32(Console.ReadLine());
            }


 
            int max = temp[0];
            int indexLast = 1;
            int sum = 0;
            //number list
            for ( i = 1; i < temp.Length; i++)
            {
                //
                if (temp[i - 1] < temp[i])
                {
                    for (int j = indexLast; j < i; j++)
                    {
                        if (temp[i] > temp[j] && temp[indexLast] > temp[j])
                        {
                            if (temp[i] > temp[indexLast])
                            {
                                sum = sum + (temp[indexLast] - temp[j]);
                                temp[j] = temp[j] + (temp[indexLast] - temp[j]);
                            }
                            else
                            {
                                sum = sum + (temp[i] - temp[j]);
                                temp[j] = temp[j] + (temp[i] - temp[j]);

                            }

                        }

                    }
                }
                if (max <= temp[i])
                {

                    indexLast = i;
                    max = temp[i];
                }

            }

            Console.WriteLine("Volume water:", sum);
        }
    }
}
