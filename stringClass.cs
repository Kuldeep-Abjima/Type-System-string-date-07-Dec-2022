using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Dec072022
{
    public class stringClass
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the text");
            var text = Console.ReadLine();
            Console.WriteLine(text);
            int k = text.Length;
            string[] a = new string[k];

            for (int i = 0; i < k; i++)
            {
                {

                    a[i] = text.Substring(0, i + 1);



                    //for(int i = 0; i < a.Length; i++)
                    //{
                    //    Console.Write($"Partation of array : {a[i]},");
                    //}
   


                }
            }
            Console.WriteLine($"[{string.Join(",", a)}]");
        }
    }
}
