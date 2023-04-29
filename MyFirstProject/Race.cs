using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Role : Entity
    {
        private static int hp = hp;
        protected int Hp { get; set; }

        public Role(string race) : base("Test", "male", race hp)
        {

            switch(race)
            {
                case "Orc":
                    Hp = 120;
                    break;

                case "HighElf":
                    Hp = 80;
                    break;

                case "Human":
                    Hp = 100;
                    break;

                default:
                    Hp = 100;
                    break;
            }
        }


    }
}
