using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("HOLA MUNDO!!!");
            int num1 = 5;
            double numero3 = 2.57;
            double suma;
            suma = num1 + numero3;

            Console.WriteLine(suma);
            Console.WriteLine("INTRODUCIR NÚMERO");
            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();
        }
    }
}
