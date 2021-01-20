using System;
using System.Collections.Generic;

namespace Kolections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"İlknur" ,"Tuğba" ,"ali","Meryem"};

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List<string> {"İlknur", "Tuğba", "ali", "Meryem" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Binboğa");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
