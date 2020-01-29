using System;
using System.Collections.Generic;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadMultiplos;
            //var multiplos = new List<int>();
            //Console.WriteLine("Ingresar un numero cualquiera: ");
            //numero = int.Parse(Console.ReadLine());
            Console.Write("Ingresa la cantidad de multiplos de 3 y no de 5 que quieres obtener: ");
            cantidadMultiplos = int.Parse(Console.ReadLine());
            Console.WriteLine("Los primeros {0} multiplos de 3 y no de 5 que quieres obtener: ", cantidadMultiplos);
            for (int i = 1; i <= cantidadMultiplos; i++)
            {
                if (i % 3 == 0  &&  i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
