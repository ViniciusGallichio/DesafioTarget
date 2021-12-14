using System;

namespace Conversão_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            char[] conversão = a.ToCharArray();
            string b = String.Empty;
            for (var i = conversão.Length - 1; i >= 0; i--)
            {
                b += a[i];
            }

            Console.WriteLine();
            Console.WriteLine(b);
        }
    }
}
