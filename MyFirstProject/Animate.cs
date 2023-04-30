using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyFirstProject
{
    public static class Animate
    {
        /// <summary>
        /// Animates a rolling die and then displays the die face with a simple graphic.
        /// </summary>
        /// <param name="number">Die number</param>
        public static void RollDie(int number)
        {
            int ROTATIONS = 6;
            int START_SPEED = 80;
            int SPEED_DECAY = 20;

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string[] frames = { "\u25A1", "\u2206", "\u25A1" };

            Console.WriteLine("Rolling die...");
            for (int i = 0; i < ROTATIONS; i++)
            {
                for(int j = 0; j < frames.Length; j++)
                {
                    Console.Write(frames[j]);
                    Thread.Sleep(START_SPEED + (i * SPEED_DECAY));
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(Console.CursorLeft - (ROTATIONS * frames.Length), Console.CursorTop);

            string[] diceFaces = {
                " _______\n|       |\n|   *   |\n|_______|", // Face 1
                " _______\n| *     |\n|       |\n|_____*_|", // Face 2
                " _______\n| *     |\n|   *   |\n|_____*_|", // Face 3
                " _______\n| *   * |\n|       |\n|_*___*_|", // Face 4
                " _______\n| *   * |\n|   *   |\n|_*___*_|", // Face 5
                " _______\n| *   * |\n| *   * |\n|_*___*_|", // Face 6
            };
            Console.Write(diceFaces[number-1]); 
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Animates a "typing" effect of a string of text.
        /// </summary>
        /// <param name="text">Text to animate typing</param>
        public static void Text(string text) {
            int SPEED = 20; //Delay in milliseconds between each keystroke
            int PARAGRAPH_PAUSE = 300; //Pause after a dot, in milliseconds

            for (int i = 0; i < text.Length; i++) {
                Console.Write(text[i]);

                if (text[i].ToString() == ".") {
                    Thread.Sleep(PARAGRAPH_PAUSE);
                } else {
                    Thread.Sleep(SPEED);
                }
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Animates "loading" dots on the screen with a set delay in between.
        /// </summary>
        public static void Loading()
        {
            int LOOPS = 3; //Amount of loops
            int DOTS = 3; //Amount of dots
            int DELAY = 200; //Delay between each dot and refresh
            string PADDING = " "; //Padding in between dots

            //Loops
            for (int i = 0; i < LOOPS; i++) {

                //Write dots and space with padding
                for (int j = 0; j < DOTS; j++) {
                    Console.Write("." + PADDING);
                    Thread.Sleep(DELAY);
                }

                //Move back cursor to start of dots
                Console.SetCursorPosition(Console.CursorLeft - (DOTS + (PADDING.Length * DOTS )), Console.CursorTop);

                //Overwrite dots with whitespace
                for (int k = 0; k < DOTS; k++)
                {
                    Console.Write(" " + PADDING);
                }

                //Move back cursor to the start once more to make the text starts at the leftmost corner of the terminal
                Console.SetCursorPosition(Console.CursorLeft - (DOTS + (PADDING.Length * DOTS)), Console.CursorTop);
                Thread.Sleep(DELAY/2);
            }
        }
    }
}
