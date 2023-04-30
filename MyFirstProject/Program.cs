// See https://aka.ms/new-console-template for more information
using MyFirstProject;
using MyFirstProject.Roles;
using System.Data;
using System.Xml.Linq;
using System.Threading;


namespace Program {
    class Program
    {
        static void Main(string[] args) 
        {
            Animate.Text("Hi and Welcome to my Game. Are you ready?");
            Thread.Sleep(1000);
            Console.WriteLine("Press any Button to Continue!");
            

            int rollAttemt = Utilities.DiceRoll();
                Animate.RollDie(rollAttemt);
            Console.WriteLine($"You rolled a {rollAttemt}");

            Console.ReadKey();
            Console.Clear();
            dynamic player = GetPlayerInfo();
            Console.WriteLine(player.attacks[1].FailText);

            //TODO
            //Make enemy sub classes, which inherits the entity class
            //Make enemy attacks just like the players attack array

            //Battle system

            //Storyboard

        }

        // Add Methods
        static dynamic GetPlayerInfo()
        {
            string inputName;
            string inputRace;
            string inputGender;
            string inputRole;

            string[] AvailableRaces = { "Orc", "HighElf", "Human" };
            string[] AvailableRoles = { "Warrior", "Mage", "Hunter" };
            string[] AvailableGenders = { "Male", "Female" };

            Animate.Text("Firstly, I would need your name!\n What is your name?");
            inputName = Console.ReadLine();
            Console.Clear();

            Animate.Text($"{inputName} is it? Great! \nThen i would like to know what race you are!.\nThese are the avaiable Races:\n");
            //Checks if the race is avaiable and stores it
            foreach (string race in AvailableRaces)
            {
                Console.WriteLine(race);
            }

            Console.WriteLine("Which one will you Choose?");

            inputRace = Utilities.SelectOption(AvailableRaces);
            Animate.Text($"\nYou have chosen: {inputRace} now that's a great Race!");



            //Ask the player what gender they are
            Animate.Text("Then i would like to know what gender you are. And Im sure you won't be happy, but for the sake of the game you are only able to select \"Male\" or \"Female\".");
            inputGender = Utilities.SelectOption(AvailableGenders, "Sorry. But there are ONLY TWO genders you Hippie, Please enter a VALID GENDER\n");
            Animate.Text($"\nYou have chosen: {inputGender} Now thats the superior Gender.. Good choice!\n");



            Console.WriteLine("Lastly i would like to know your Class. You can choose beween the following classes:\n");
            inputRole = Utilities.SelectOption(AvailableRoles);
            Console.WriteLine($"\nYou selected {inputRole}");

            switch (inputRole)
            {
                case "Warrior":
                    return new Warrior(inputName!, inputGender, inputRace);
                    break;

                case "Mage":
                    return new Mage(inputName!, inputGender, inputRace);
                    break;

                case "Hunter":
                    return new Hunter(inputName!, inputGender, inputRace);
                    break;

                default:
                    return new Warrior(inputName!, inputGender, inputRace);
                    break;
            }
        }
    }
 }