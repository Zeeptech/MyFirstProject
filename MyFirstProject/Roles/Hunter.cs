using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Roles
{
    internal class Hunter: Entity
    {

        public Attack[] attacks = {
            
        };

    
        public Hunter(string name, string gender, string race) : base(name, gender, race)
        {

        }
    }
}
