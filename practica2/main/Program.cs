using System;
using practica2;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese texto");
            var text = Console.ReadLine();
            string textoinvertido = text.Reverse();
            Console.WriteLine(textoinvertido);


        }
    }
}
