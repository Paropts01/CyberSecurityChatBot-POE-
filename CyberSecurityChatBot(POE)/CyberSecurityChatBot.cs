using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    internal class CyberSecurityChatBot : Chatbot
    {
        public void StartChat() 
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                TypingStyle.TypeText("\nBot: What is your name? : ");
                UserName = Console.ReadLine();

                // Input validation
                if (string.IsNullOrWhiteSpace(UserName))
                {
                    UserName = "User";
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypingStyle.TypeText($"\nHello {UserName}! Welcome to the Cybersecurity Awareness Bot.");
                TypingStyle.TypeText($"How may i help you {UserName}");

                ChatLoop();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error starting chatbot: " + ex.Message);
            }
        }

        private void ChatLoop()
        {
            string userInput = "";

            string[] topics =
            {
                "password",
                "phishing",
                "safe browsing"
            };

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    TypingStyle.TypeText("\nYou: ");

                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        TypingStyle.TypeText("\nBot: Please enter a valid question.");
                        continue;
                    }

                    userInput = userInput.ToLower();

                    if (userInput.Contains("exit"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText("\nBot: Goodbye! Stay safe online!");
                        break;
                    }
                    else if (userInput.Contains("how are you"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText("\nBot: I'm running perfectly and ready to help you stay safe online!");
                    }
                    else if (userInput.Contains("purpose"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText("\nBot: My purpose is to teach people about cybersecurity awareness.");
                    }
                    else if (userInput.Contains("password"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText("\nBot: Use strong passwords with letters, numbers and symbols.");
                    }
                    else if (userInput.Contains("phishing"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText("\nBot: Phishing is when attackers trick you into giving personal information through fake emails or websites.");
                    }
                    else if (userInput.Contains("safe browsing"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText("\nBot: Only visit trusted websites and avoid clicking suspicious links.");
                    }
                    else

                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        TypingStyle.TypeText("\nBot: I didn't quite understand that. Could you rephrase?");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
