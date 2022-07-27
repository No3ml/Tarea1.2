using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("HOLA MUMDO!!!");
            int num1 = 5;
            int nuero2 = 6;
            double num3 = 2.57;
            double suma;
            suma = num1 + num3;

            Console.WriteLine(suma);
            string Valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es:" + Valor1);
            int valorint = Convert.ToInt32(Valor1);

            Console.ReadKey();
        }
    }
}
