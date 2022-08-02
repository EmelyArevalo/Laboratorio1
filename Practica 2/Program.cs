using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 27;
            var suma = num1 + num2;
            int edad = 17;
            string name = "Emely";
            //Imprimir datos 
            Console.WriteLine(suma);
            Console.WriteLine("Su nombre es: {1} y su edad es: {0}", edad, name);
        }
    }
}
