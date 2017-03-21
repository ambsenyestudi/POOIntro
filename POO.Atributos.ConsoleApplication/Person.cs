using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Atributos.ConsoleApp
{
    public class Person
    {
        private string _name;
        private string _surname;
        //constructor 
        public Person()
        {
            _name = String.Empty;
            _surname = String.Empty;
        }
        //sobrecarga de constructor
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetSurname(string surname)
        {
            _surname = surname;
        }
        public string GetSurname()
        {
            return _surname;
        }
    }
}
