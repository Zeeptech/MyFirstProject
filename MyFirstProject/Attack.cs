using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Attack
    {
        public string Name{ get; set; }   
        public string AttackText { get; set; }
        public string FailText { get; set; } 
        public string CritText { get; set; }
        public string Role { get; set; }

        public Attack(string name, string attackText, string failText, string critText)
        {
            this.Name = name; 
            this.AttackText = attackText;   
            this.FailText = failText;
            this.CritText = critText;
            this.Role = Role;
        }

        /*  En början/ Tanke på hur en attackRoll kan se ut. Måste komma på hur vi implementerar vilken spell-Line vi ska kö
        public Attack AttackDice()
        {
            int roll = new Random().Next(1, 7); // roll a random number between 1 and 6
            Attack attack = new Attack();

            switch (roll)
            {
                case 1:
                    FailText;
                    break;
                case 6:
                    CritText;
                    break;
                default:
                    AttackText;
                    break;
            }

            return attack;
        } */
    }
}
