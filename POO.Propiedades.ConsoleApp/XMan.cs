using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Propiedades.ConsoleApp
{
    public class XMan
    {
        public string Name { get; set; }
        public List<string> SuperPowers { get; set; }

        public string GetSuperPowers()
        {
            string superPowersResult = "";
            foreach (var superPower in SuperPowers)
            {
                superPowersResult += superPower + " ";
            }
            return superPowersResult;
        }
    }
}
