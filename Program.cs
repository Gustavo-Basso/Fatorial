using System;

namespace FatorialPj {

    internal class Program {


        static void Main(string[] args) {


            Console.Write("Factorial valor:  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Entities fac = new Entities(n);
            Console.WriteLine(fac);


        }


    }

}