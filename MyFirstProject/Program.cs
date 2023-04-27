// See https://aka.ms/new-console-template for more information
using MyFirstProject;
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
            
            
         string[] AvaiableRaces = { "Orc", "HighElf", "Human" };
         string[] AvaiableRoles = { "Warrior", "Mage", "Hunter" };



           Console.WriteLine("Hi and Welcome to my Game. Are you ready? \n Press any Button to Continue!\n");
            Console.ReadKey();
            Console.WriteLine("Firstly, I would need your name!\n What is your name:");
            inputName = Console.ReadLine();
            Console.WriteLine($"{inputName} is it? Great! \nThen i would like to know what race you are!.\nThese are the avaiable Races:\n");
                foreach (string race in AvaiableRaces)
            {
                Console.WriteLine(race);
            }
            Console.WriteLine("Which one will you Choose?");
                inputRace = Console.ReadLine();

            Console.WriteLine($"You have chosen: {inputRace} now thats a great Race!");
            Console.WriteLine("Then i would like to know what gender you are. And Im sure you won't be happy, but for the sake of the game you are only able to select \"Male\" or \"Female\".");
                inputGender = Console.ReadLine();

            Console.WriteLine("Now thats the superior Gender.. Good choice!");
            Console.WriteLine("Lastly i would like to know your Class. You can choose beween the following classes:");
                foreach (string role in AvaiableRoles)
            {
                Console.WriteLine(role);
            }
                inputRole = Console.ReadLine();
            
               
            
            

        
        
        
        
        }
        // Add Methods

        
    }

   
 }