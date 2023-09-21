using System;
using System.Runtime.Serialization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B,soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + (soma));

            Console.ReadLine();
        }
    }
}