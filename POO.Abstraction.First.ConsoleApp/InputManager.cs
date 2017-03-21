using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.First.ConsoleApp
{
    public class InputManager
    {
        private string _errorMessage = "Numero no valido intente de nuevo";
        
        public int GetInput()
        {
            int number = 0;
            bool isNumber = false;
            while (!isNumber)
            {
                isNumber = (int.TryParse(Console.ReadLine(), out number));
                if (!isNumber)
                {
                    Console.WriteLine(_errorMessage);
                }
            }
            return number;
        }
    }
}
