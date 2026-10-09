// brainc3l

/* Color Code:
 * Red: Error
 * Yellow: Warning/Important
 * Blue: Key
 * DarkBlue: Press any key
 * White: Info
 */

// Initialization
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

// Welcome Screen
Console.WriteLine(@" _           _         ___ _ 
| |_ ___ ___|_|___ ___|_  | |
| . |  _| .'| |   |  _|_  | |
|___|_| |__,|_|_|_|___|___|_|");
Console.WriteLine("A free, open-source, simple yet helpful project that lets you study with flashcards.");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("\n PRESS [ANY KEY] TO START... ");
Console.ReadKey();

// Main Screen
for (; ; )
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[Q] Quit");
    ConsoleKeyInfo option = Console.ReadKey();

    if (option.KeyChar == 'q')
    {
        for (; ; )
        {
            // Exit Confirmation
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WAIT!!!");
            Console.WriteLine("Make sure to export all your decks and config to not lose them!");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Are you SURE you want to exit? [Y/N] ");
            ConsoleKeyInfo exitConfirmation = Console.ReadKey();

            if (exitConfirmation.KeyChar == 'y')
                return;
            else if (exitConfirmation.KeyChar == 'n')
                break;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Key Press.");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("PRESS [ANY KEY] TO CONTINUE... ");
                Console.ReadKey();
                continue;
            }
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid Key Press.");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("PRESS [ANY KEY] TO CONTINUE... ");
        Console.ReadKey();
    }
}