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
        public int Damage { get; set; }    
        public string AttackText { get; set; }
        public string FailText { get; set; } 
        public string CritText { get; set; }
        public string Role { get; set; }

        public Attack(string name, int damage, string attackText, string failText, string critText)
        {
            this.Name = name;
            this.Damage = damage;   
            this.AttackText = attackText;   
            this.FailText = failText;
            this.CritText = critText;
            this.Role = Role;
        }
    }
}
