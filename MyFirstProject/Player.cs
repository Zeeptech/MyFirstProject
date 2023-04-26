using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
     class Player
    {
        //Fields == Basic data
        private string name = "null";
         private string race = "null";
         private string gender = "null";
         private string role = "null";
         private int hp = 10;
         private int exp = 0;
         private int level = 1;
         private int mp = 0;




        //Properties == Runs through rules
        public string Name
        {
            get { return name; } set {  name = value; }
        }
        public string Race
        {
            get { return race; } set { race = value; }
        }
        public string Gender
        {
            get { return gender; } set { gender = value;}
        }
        
        public string Role
        {
            get { return role; } set { role = value; }
        }
        public int Hp
        {
            get { return hp; } set { hp = value; }
        }
        public int Exp
        {
            get { return exp; } set { exp = value; }    
        }
        public int Level
        {
            get { return level; } set { level = value; }    
        }
        public int Mp
        {
            get { return mp; } set { mp = value;}
        }

        //Constructors == Methods that runs when a new class is added
        public Player(string name, string race, string gender, string role)
        {
            this.name = name;
            this.race = race;  
            this.gender = gender;
            this.role = role;
               
        }
    }
}
