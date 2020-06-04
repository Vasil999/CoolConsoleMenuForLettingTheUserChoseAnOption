using System;

namespace CooleConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int selectedClass = ConsoleHelper.MultipleChoice(true, "Warrior", "Bard", "Mage", "Archer", "Thief", "Assassin", "Cleric", "Paladin", "etc.");
            Console.WriteLine();
            Console.WriteLine(selectedClass);
        }
    }
}
