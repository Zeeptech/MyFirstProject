using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Roles
{
    class Mage : Entity
    {
        public Attack[] attacks = {
            new Attack(
                "Shadow Bolt",
               "You shoot a bolt of shadow magic at your enemy, dealing moderate damage and reducing their accuracy.",
               "Your spell explodes in your face, blinding you and leaving you vulnerable to attack.",
               "You channel pure darkness into your spell, completely obliterating your enemy and causing fear in all nearby foes."
            ),
            new Attack(
                "Chain Lightning",
               "You unleash a bolt of lightning that arcs between multiple enemies, dealing moderate damage to each.",
               "Your spell backfires, shocking you and your allies instead of your enemies.",
               "You unleash a massive bolt of lightning that arcs between multiple enemies, completely frying them."
            ),
            new Attack(
                "Frost Nova",
               "You create a blast of icy wind that damages and slows your enemies.",
               "You accidentally freeze yourself, leaving you helpless and vulnerable to attack.",
               "You channel a frigid storm that freezes all nearby enemies solid."
            ),
        };



        public Mage(string name, string gender, string race) : base(name, gender, race)
        {

           


        }
        public void CastSpell()
        {

        }


    }
}
