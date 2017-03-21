using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Abstraction.Second.ConsoleApp
{
    public class OutputManager
    {
        private string[] _introductionSentences;
        private bool _isIntroDone = false;
        public OutputManager()
        {
            _introductionSentences = new string[2];
            _introductionSentences[0] = "Bienvendio a nuestra calcualdora para sumar";
            _introductionSentences[1] = "Vamos a sumar dos numeros";
        }
        //propiedad
        public bool IsIntroDone {
            get
            {
                return _isIntroDone;
            }
        }

        public void DoIntroduction()
        {
            int count = 0;
            while(count<_introductionSentences.Length)
            {
                Console.WriteLine(_introductionSentences[count]);
                count++;
            }
            _isIntroDone = true;
        }

        internal void PrintAddition(List<int> numberList, int result)
        {
            string additionSentece = "";
            int count = 0;
            while(count<numberList.Count)
            {
                additionSentece += numberList[count] + " ";
                if((count+1)< numberList.Count)
                {
                    additionSentece += "+ ";
                }
                count++;
            }
            additionSentece += "= " + result;
            Console.WriteLine(additionSentece);
        }
    }
}
