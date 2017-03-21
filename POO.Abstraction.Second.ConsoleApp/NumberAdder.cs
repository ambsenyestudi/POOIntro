using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.Second.ConsoleApp
{
    public class NumberAdder
    {
        private List<int> _numberList;
        private int nNumbers;
        private InputManager _inputManager;
        public NumberAdder()
        {
            _inputManager = new InputManager("Porfavor introduzca un número correcto");
            _numberList = new List<int>();
            nNumbers = 2;
        }
        public List<int> NumberList {
            get
            {
                return _numberList;
            }
        }

        public void GatherNumbersFromUser()
        {
            
            int count = 0;
            while (count < nNumbers)
            {
                Console.WriteLine("Introduzca un numero");
                int currInput = _inputManager.GetInput();
                _numberList.Add(currInput);
                count++;
            }
        }

        public  int FigureResult()
        {
            int result = 0;
            int count = 0;
            while(count < _numberList.Count)
            {
                result += _numberList[count];
                count++;
            }
            return result;
        }
    }
}
