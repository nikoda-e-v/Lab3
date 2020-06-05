using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace unitTest_3
{
  public  class Program
    {

        public static void ReadWrite(string adress1, string adress2)
        {
            List<string> lines = File.ReadAllLines(adress1).ToList<string>();
            lines.Sort((string x, string y) => x.Length.CompareTo(y.Length));
            File.WriteAllLines(adress2, lines.ToArray());
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторна робота №5");
        }
    }
}
