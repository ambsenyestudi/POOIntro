using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Atributos.ConsoleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            //Array con 2 posiciones
            Person[] people = new Person[2];
            //Creamos persona en la primera posición del array
            people[0]=new Person("Joan Ramon", "Alemany");
            //Creamos una persona cualquiera
            Person person = new Person();
            //Asingnamos su atributos mediante metodos tipo set
            person.SetName("Adrià");
            person.SetSurname("Freixas");
            //Asignamos la persona creada a la segunda posición del array
            people[1] = person;

            //listamos la personas
            int count = 0;
            Console.WriteLine("Vamos ha hacer una lista de profesores:");
            Console.WriteLine("###########################################");
            while (count<people.Length)
            {
                Console.WriteLine(people[count].GetName() + " " + people[count].GetSurname());
                //no olvidar nunca incrementar el contador!!!
                count++;
            }
            Console.Read();
        }
    }
}
