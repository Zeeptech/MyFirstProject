using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    public class Utilities
    {
        public static bool IsInArray(string[] arrays, string keyword)
        {
            bool exist = false;
            if (Array.Exists(arrays, item => item.ToLower() == keyword.ToLower()))
            {

                exist = true;
            }
            return exist;
        }

        /// <summary>
        /// Prompts the user to enter a key which is an int. Prompts again if the input is not parsable to an int
        /// </summary>
        /// <returns>The value parsed to an int.</returns>
        private static int GetValidIntFromConsole()
        {
            int value;
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey();
            }
            //If not an int, ask for value again
            while (!int.TryParse(keyInfo.KeyChar.ToString(), out value));

            return value;
        }

        /// <summary>
        /// Prompts the user to pick an option from an array of strings.
        /// The method will persist and repeat the question until the user has picked a valid option.
        /// </summary>
        /// <param name="options">String array of available options for the user.</param>
        /// <param name="wrongChoiceWarning">Optional custom message to display if an incorrect option is selected. Defaults to "Please enter a valid option."</param>
        /// <returns>The selected option</returns>
        public static string SelectOption(string[] options, string wrongChoiceWarning = "Please enter a valid option.")
        {
            Console.WriteLine("Options:");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i +1} = {options[i]}");
            }

            int selectedOption = GetValidIntFromConsole() -1;

            while(selectedOption > options.Length -1)
            {
                Console.WriteLine($"\n{wrongChoiceWarning}");
                selectedOption = GetValidIntFromConsole() - 1;
            }
            
            return options[selectedOption];
        }
        
    }
}
