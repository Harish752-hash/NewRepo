using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Ad ad = new Ad(89, 56);
            int x = ad.Addition(ad);
            Console.WriteLine(x);
        }
    }
}
