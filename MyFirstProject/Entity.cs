using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
      class Entity
    {
        //Fields == Basic data
        protected string name = "null";
        protected string gender = "null";
        protected string race;
        protected int hp;
        protected int level = 1;


        //Properties == Runs through rules
        public string Name
        {
            get { return name; } set {  name = value; }
        }

        public string Gender
        {
            get { return gender; } set { gender = value;}
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public int Hp
        {
            get { return hp; } set { hp = value; }
        }

        public int Level
        {
            get { return level; } set { level = value; }    
        }


        //Constructors == Methods that runs when a new class is added
        public Entity(string name, string gender, string race)
        {
            this.Name = name;  
            this.Gender = gender;
            this.Race = race;

            switch (race)
            {
                case "Orc":
                    this.Hp = 120;
                    break;

                case "HighElf":
                    this.Hp = 80;
                    break;

                case "Human":
                    this.Hp = 100;
                    break;

                default:
                    this.Hp = 100;
                    break;
            }
        }
        // Methods
        public void LevelUp()
        {
            Level++;
            Hp += 15;
            

        }
    }
}
