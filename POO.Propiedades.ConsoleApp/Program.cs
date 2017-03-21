using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Propiedades.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a listar algunos xMan");
            Console.WriteLine("\n\n");
            List<XMan> xMen = new List<XMan>();
            //ProfessonX
            XMan professorX = new XMan();
            professorX.Name = "Charles Xavier";
            List<string> professorXSuperPowers = new List<string>();
            professorXSuperPowers.Add("Telepathy");
            professorX.SuperPowers = professorXSuperPowers;
            xMen.Add(professorX);
            //Cyclops
            XMan cyclops = new XMan { Name = "Cyclops"};
            List<string> cyclopsSuperPowers = new List<string>
            { "Eyes emit laser beams" };
            cyclops.SuperPowers = cyclopsSuperPowers;
            xMen.Add(cyclops);
            //Rondador nocturno
            XMan rondadorNocturon = new XMan
            {
                Name = "Nightcrawler",
                SuperPowers = new List<string> { "Telekinesis" }
            };
            xMen.Add(rondadorNocturon);
            //Lobezno
            xMen.Add(
                new XMan
                {
                    Name="Wolverine",
                    SuperPowers=new List<string>
                    { "Super strength", "Super healing", "Claws"}
                });
            
            foreach (var xman in xMen)
            {
                Console.WriteLine("################################");
                Console.WriteLine("Nombre "+xman.Name);
                string superPoder = "Superpoder : ";
                if(xman.SuperPowers.Count>1)
                {
                    superPoder = "Super poderes : ";
                }
                superPoder += xman.GetSuperPowers();
                Console.WriteLine(superPoder);
            }
            Console.Read();
        }
    }
}
