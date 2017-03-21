using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.Second.ConsoleApp
{
    public class AdditionManager
    {
        private bool _isAdditonDone = false;
        NumberAdder _adder;
        OutputManager _outputManager;
        public AdditionManager()
        {
            _adder = new NumberAdder();
            _outputManager = new OutputManager();
        }
        public void Run()
        {
            if(!_outputManager.IsIntroDone)
            {
                _outputManager.DoIntroduction();
            }
            else
            {
                _adder.GatherNumbersFromUser();
                _outputManager.PrintAddition(_adder.NumberList, _adder.FigureResult());
                _isAdditonDone = true;
            }
            
        }
        public bool getIsAdditionDone()
        {
            return _isAdditonDone;
        }
    }
}
