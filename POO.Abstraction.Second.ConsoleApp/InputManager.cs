using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.Second.ConsoleApp
{
    public class InputManager
    {
        private string _errorMessage;
        //constructor por defecto
        public InputManager()
        {
            _errorMessage = "Numero no valido intente de nuevo";
        }
        //sobre carga de constructor
        public InputManager(string message)
        {
            _errorMessage = message;
        }
        //Metodo
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
