/*
 * Nebula Prime
 * by Oliver Jones, 02/03/2023
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using Adventure.Scenario;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Adventure
{
    public static class Game
    {
        static string characterName;
        static string input;
        static bool goodEnd = false;
        static bool badEnd = false;
        static int choice;

        public static void StartMenu()
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("1) New game");
            Console.WriteLine("2) Continue game");
            Console.WriteLine("3) Exit game");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Intro();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("To do: program save/load functionality");
                        Console.ResetColor();
                        ContinueGame();
                        StartMenu();
                        break;
                    case 3:
                        exitGame();
                        break;
                    default:
                        Console.WriteLine("\nPlease enter a number between 1-3.");
                        ContinueGame();
                        StartMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter a number between 1-3.");
                ContinueGame();
                StartMenu();
            }
        }
        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" _   _      _           _         _____      _                ");
            Console.WriteLine(@"| \ | |    | |         | |       |  __ \    (_)               ");
            Console.WriteLine(@"|  \| | ___| |__  _   _| | __ _  | |__) | __ _ _ __ ___   ___ ");
            Console.WriteLine(@"| . ` |/ _ \ '_ \| | | | |/ _` | |  ___/ '__| | '_ ` _ \ / _ \");
            Console.WriteLine(@"| |\  |  __/ |_) | |_| | | (_| | | |   | |  | | | | | | |  __/");
            Console.WriteLine("|_| \\_|\\___|_.__/ \\__,_|_|\\__,_| |_|   |_|  |_|_| |_| |_|\\___|\n\n");
            Console.ResetColor();
            Console.WriteLine("Welcome to the world of Nebula Prime! You will soon embark on \nan epic journey through the far reaches of space, encountering \nstrange creatures, hostile environments, and deadly obstacles \nalong the way. As the captain of your own starship, you'll \nexplore uncharted territories, uncover hidden secrets, and \nmake crucial decisions that will determine the fate of your \ncrew and the galaxy at large. With every twist and turn in \nthe story, you'll face new challenges and opportunities, \ntesting your skills and your wit to the limit. So strap in, \nset your course, and get ready for the adventure of a lifetime!");
            ContinueGame();
            NameChar();
        }
        public static void End()
        {
            if (goodEnd = true)
            { 
                Console.WriteLine("good end text");
                ContinueGame();
            }
            else if (badEnd=true)
            {
                Console.WriteLine("bad end text");
                ContinueGame();
            }
            StartMenu();
        }
        static void NameChar()
        {
            Console.WriteLine("\nPlease enter a name for your character: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            characterName = Console.ReadLine();
            Console.ResetColor();
            ConfirmNameChar();
        }
        static void ConfirmNameChar()
        { 
            Console.WriteLine($"\nYour character is now named {characterName}. Is this correct?\n1) Yes\n2) No");
            Console.ForegroundColor = ConsoleColor.Magenta;
            input = Console.ReadLine();
            Console.ResetColor();
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        StartMenu();
                        break;
                    case 2:
                        NameChar();
                        break;
                    default:
                        InvalidInput("1-2");
                        ConfirmNameChar();
                        break;
                }
            }
            else
            {
                InvalidInput("1-2");
                ConfirmNameChar();
            }
        }
        static void Intro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" _   _      _           _         _____      _                ");
            Console.WriteLine(@"| \ | |    | |         | |       |  __ \    (_)               ");
            Console.WriteLine(@"|  \| | ___| |__  _   _| | __ _  | |__) | __ _ _ __ ___   ___ ");
            Console.WriteLine(@"| . ` |/ _ \ '_ \| | | | |/ _` | |  ___/ '__| | '_ ` _ \ / _ \");
            Console.WriteLine(@"| |\  |  __/ |_) | |_| | | (_| | | |   | |  | | | | | | |  __/");
            Console.WriteLine("|_| \\_|\\___|_.__/ \\__,_|_|\\__,_| |_|   |_|  |_|_| |_| |_|\\___|\n\n");
            Console.ResetColor();
            Console.WriteLine($"\nYou are Captain {characterName}, and you have dedicated your life\nto exploring the unknown depths of space. As the captain\nof the starship Odyssey, you and your crew have faced\ncountless challenges and encountered wonders beyond your wildest dreams.\nBut your latest mission will be your most perilous yet,\nas you venture into the heart of a mysterious anomaly\nand uncover secrets that could change the course of history.\nYour fate rests in your hands, and you must do\neverything in your power to lead your crew to victory.");
            ContinueGame();
            UndeterminedEnd.beforeBranch();
        }
        static void ContinueGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress any key to continue...");
            Console.ResetColor();
            Console.ReadKey();
        }
        internal static void InvalidInput(string userInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Invalid input. Please enter a number between {userInput}.");
            Console.ResetColor();
        }
        internal static void exitGame()
        {
            Console.WriteLine("\nExiting...");
            Environment.Exit(0);
        }
        static void Dialogue(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }
    }
}
