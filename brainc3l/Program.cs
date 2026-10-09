// brainc3l

/* Color Code:
 * DarkCyan: Press any key
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

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("\n PRESS [ANY KEY] TO START... ");
Console.ReadKey();

// Exit Screen
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("PRESS [ANY KEY] TO EXIT... ");
Console.ReadKey();