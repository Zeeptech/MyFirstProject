using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Roles
{
    internal class Mage : Entity
    {
        public string mainSpell;

        public Mage(string name, string gender, string race) : base(name, gender, race)
        {
            
           


        }
        public void CastSpell()
        {

            Console.WriteLine($" You cast {mainSpell} ");

        }


    }
}
