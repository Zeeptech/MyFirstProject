using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Enemy : Entity
    {
        public Attack[] attacks = {
            new Attack("Test", "AttackTest", "FailTest", "CritTest"

         ),
            new Attack("Test", "AttackTest", "FailTest", "CritTest"

         ),
            new Attack("Test", "AttackTest", "FailTest", "CritTest")



        };

        public Enemy(string name, string gender, string race) : base(name, gender, race)
        {


        }
    }
}
