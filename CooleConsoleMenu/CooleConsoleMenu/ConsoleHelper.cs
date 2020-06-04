using System;
using System.Collections.Generic;
using System.Text;

namespace CooleConsoleMenu
{
    class ConsoleHelper
    {

                                                         //these parameters should be always at the end
        public static int MultipleChoice(bool canCancel, params string[] options)
        {
            //setting starting points for our program
            const int startX = 15;
            const int startY = 8;

            //setting the values for our lines
            const int optionsPerLine = 3;
            const int spacingPerLine = 14;

            int currentSelection = 0;

            ConsoleKey key;

            //hide the cursor for not confusing the user
            Console.CursorVisible = false;

            do
            {
                //clearing the Console
                Console.Clear();

                //making sure, the option, where the cursor is at, is marked red
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                //making sure, the user controls the cursor comfortabely on the menu
                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                    {
                        if (canCancel)
                            return -1;
                            break;
                    }
                }

            } while (key != ConsoleKey.Enter);

            //Making the cursor visible again for further using from the user
            Console.CursorVisible = true;

            //returning the index of the chosen option
            return currentSelection;
        }
    }
}
