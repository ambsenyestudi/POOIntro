using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.First.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputManager inputManager = new InputManager();
            Console.WriteLine("Vamos a sumar dos numeros, introduzca el primer numero");
            int a = inputManager.GetInput();
            Console.WriteLine("Introduzca el segundo numero");
            int b = inputManager.GetInput();
            Console.WriteLine("Calculando resulstado...");
            int resultado = a + b;
            Console.WriteLine(a + " + " + b + " = " + resultado);
            Console.WriteLine("Pulse cualquier tecla para finalizar programa");
            //solo para que el programa no se acabe hasta que el usuario pulse una tecla
            Console.Read();
        }
    }
}
