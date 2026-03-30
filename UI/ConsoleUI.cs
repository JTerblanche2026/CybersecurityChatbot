using System;

namespace CybersecurityChatbot.UI
{
    public static class ConsoleUI
    {
        //Colour helpers 
        public static void WriteColour(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void WriteInline(string text, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.Write(text);
            Console.ResetColor();
        }

        //Typing effect 
        public static void TypeWrite(string text, ConsoleColor colour, int delay = 30)
        {
            Console.ForegroundColor = colour;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        //Divider 
        public static void PrintDivider()
        {
            WriteColour("═══════════════════════════════════════════════════════", ConsoleColor.DarkCyan);
        }

        //ASCII Art Logo 
        public static void PrintLogo()
        {
            Console.Clear();
            PrintDivider();
            WriteColour(@"
   ██████╗██╗   ██╗██████╗ ███████╗██████╗      
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗     
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝     
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗     
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║     
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝    
                                                 
   Cybersecurity Awareness Bot            
   Keeping South Africa Safe Online             
", ConsoleColor.Cyan);
            PrintDivider();
        }

        //Bot message 
        public static void BotMessage(string message)
        {
            Console.WriteLine();
            WriteInline("  🤖 Bot: ", ConsoleColor.Green);
            TypeWrite(message, ConsoleColor.White);
        }

        //User prompt ──────────────────────────────────────────────
        public static void UserPrompt()
        {
            Console.WriteLine();
            WriteInline("  You: ", ConsoleColor.Yellow);
        }

        //header ───────────────────────────────────────────
        public static void PrintHeader(string title)
        {
            Console.WriteLine();
            PrintDivider();
            WriteColour($"  {title}", ConsoleColor.Cyan);
            PrintDivider();
        }
    }
}