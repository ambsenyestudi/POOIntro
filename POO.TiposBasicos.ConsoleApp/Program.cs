using System;
using System.Collections.Generic;
using System.Linq;

namespace POO.TiposBasicos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a sumar dos numeros, introduzca el primer numero");
            int a  = 0;
            bool isA = false;
            while (!isA)
            {
                isA = (int.TryParse(Console.ReadLine(), out a));
                if(!isA)
                {
                    Console.WriteLine("Numero no valido intente de nuevo");
                }
            }
            Console.WriteLine("Introduzca el segundo numero");
            int b = 0;
            bool isB = false;
            while (!isB)
            {
                isB = int.TryParse(Console.ReadLine(), out b);
                if(!isB)
                {
                    Console.WriteLine("Numero no valido intente de nuevo");
                }
            }
            Console.WriteLine("Calculando resulstado...");
            int resultado = a + b;
            Console.WriteLine(a + " + " + b + " = " + resultado);
            Console.WriteLine("Pulse cualquier tecla para finalizar programa");
            //solo para que el programa no se acabe hasta que el usuario pulse una tecla
            Console.Read();
        }
    }
}
