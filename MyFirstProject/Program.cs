// See https://aka.ms/new-console-template for more information
using MyFirstProject;
using System.Data;
using System.Xml.Linq;


namespace Program {
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Hi and Welcome to my Game. Are you ready? \n Press any Button to Continue!\n");
            Console.ReadKey();
            //Entity player = GetPlayerInfo();
            







        }



        // Add Methods
        /*
        static Entity GetPlayerInfo()
        {
            string inputName;
            string inputRace;
            string inputGender;
            string inputRole;

            string[] AvailableRaces = { "Orc", "HighElf", "Human" };
            string[] AvailableRoles = { "Warrior", "Mage", "Hunter" };
            string[] AvailableGenders = { "Male", "Female" };

            Console.WriteLine("Firstly, I would need your name!\n What is your name:");
            inputName = Console.ReadLine();
            Console.WriteLine($"{inputName} is it? Great! \nThen i would like to know what race you are!.\nThese are the avaiable Races:\n");
            //Checks if the race is avaiable and stores it
            foreach (string race in AvailableRaces)
            {
                Console.WriteLine(race);
            }

            Console.WriteLine("Which one will you Choose?");

            inputRace = Utilities.SelectOption(AvailableRaces);
            Console.WriteLine($"\nYou have chosen: {inputRace} now that's a great Race!");



            //Ask the player what gender they are
            Console.WriteLine("Then i would like to know what gender you are. And Im sure you won't be happy, but for the sake of the game you are only able to select \"Male\" or \"Female\".");
            inputGender = Utilities.SelectOption(AvailableGenders, "Sorry. But there are ONLY TWO genders you Hippie, Please enter a VALID GENDER\n");
            Console.WriteLine($"\nYou have chosen: {inputGender} Now thats the superior Gender.. Good choice!\n");



            Console.WriteLine("Lastly i would like to know your Class. You can choose beween the following classes:\n");
            inputRole = Utilities.SelectOption(AvailableRoles);
            Console.WriteLine($"\nYou selected {inputRole}");

            return new Entity(inputName!, inputGender);
        }
        */
    }
 }