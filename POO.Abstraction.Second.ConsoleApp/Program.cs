using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.Second.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionManager additionManager = new AdditionManager();
            while (!additionManager.getIsAdditionDone())
            {
                additionManager.Run();
            }
            //solo para que el programa no se acabe hasta que el usuario pulse una tecla
            Console.Read();
        }
    }
}
