// See https://aka.ms/new-console-template for more information
using MyFirstProject;
using System.Data;
using System.Xml.Linq;


namespace Program {
    class Program
    {
        static void Main(string[] args) 
        {
            string inputName;
            string inputRace;
            string inputGender;
            string inputRole;

            // CAN BE DELETED!

            /*
            bool validRace = false;
            bool validGender = false;
            */
            
            string[] AvailableRaces = { "Orc", "HighElf", "Human" };
            string[] AvailableRoles = { "Warrior", "Mage", "Hunter" };
            string[] AvailableGenders = { "Male", "Female" };


            Console.WriteLine("Hi and Welcome to my Game. Are you ready? \n Press any Button to Continue!\n");
            Console.ReadKey();
            Console.WriteLine("Firstly, I would need your name!\n What is your name:");
            inputName = Console.ReadLine();
            Console.WriteLine($"{inputName} is it? Great! \nThen i would like to know what race you are!.\nThese are the avaiable Races:\n");

            foreach (string race in AvailableRaces)
            {
                Console.WriteLine(race);
            }

            Console.WriteLine("Which one will you Choose?");

            inputRace = Utilities.SelectOption(AvailableRaces);
            Console.WriteLine($"You have chosen: {inputRace} now that's a great Race!");


            // CAN BE DELETED!

            /*
                while (!validRace)
            {
                Console.WriteLine("Please enter your race:");
                string askInputRace = Console.ReadLine();
                if (Utilities.IsInArray(AvaiableRaces, askInputRace!))
                {
                    inputRace = askInputRace;
                    Console.WriteLine($"You have chosen: {inputRace} now that's a great Race!");
                    validRace = true;
                }
                else
                {
                    Console.WriteLine($"The race '{askInputRace}' is not available.");
                }
            }
            */

            Console.WriteLine("Then i would like to know what gender you are. And Im sure you won't be happy, but for the sake of the game you are only able to select \"Male\" or \"Female\".");
            inputGender = Utilities.SelectOption(AvailableGenders, "Sorry. But there are ONLY TWO genders you Hippie, Please enter a VALID GENDER\n");
            Console.WriteLine($"You have chosen: {inputGender} Now thats the superior Gender.. Good choice!\n");

            // CAN BE DELETED!

            /*
            while (!validGender)
            {
                Console.WriteLine("Please enter your gender:");
                string askInputGender = Console.ReadLine();
                if (Utilities.IsInArray(AvaiableGenders, askInputGender!))
                {
                    inputGender = askInputGender;
                    Console.WriteLine($"You have chosen: {inputGender} Now thats the superior Gender.. Good choice!\n");
                    validGender = true;
                }
                else
                {
                    Console.WriteLine($"Sorry. But there are ONLY TWO genders you Hippie, Please enter a VALID GENDER\n");
                }
            }
            */

            Console.WriteLine("Lastly i would like to know your Class. You can choose beween the following classes:\n");
            inputRole = Utilities.SelectOption(AvailableRoles);
            Console.WriteLine($"You selected {inputRole}");

            // CAN BE DELETED!

            /*
                foreach (string role in AvailableRoles)
            {
                Console.WriteLine(role);
            }
                inputRole = Console.ReadLine();
            */
        }
        // Add Methods

        
    }
 }