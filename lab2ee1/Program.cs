using System;

namespace lab2ee1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti latimea");
            var latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea");
            var lungimea = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea");
            var inaltimea = int.Parse(Console.ReadLine());

            var volum = lungimea * latime * inaltimea;
            Console.WriteLine("Volumul este " + volum);

        }
    }
}

