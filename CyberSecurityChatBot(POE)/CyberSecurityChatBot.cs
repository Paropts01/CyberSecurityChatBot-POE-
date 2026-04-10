using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    internal class CyberSecurityChatBot : Chatbot
    {
        public void StartChat() // removed override
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.Write("\nWhat is your name? : ");
                UserName = Console.ReadLine();

                // Input validation
                if (string.IsNullOrWhiteSpace(UserName))
                {
                    UserName = "User";
                }

                Console.WriteLine($"\nHello {UserName}! Welcome to the Cybersecurity Awareness Bot.");
                Console.WriteLine("Ask me about cybersecurity!\n");

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
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    TypingStyle.TypeText("\nYou: ");

                    userInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bot: Please enter a valid question.");
                        continue;
                    }

                    userInput = userInput.ToLower();

                    if (userInput.Contains("exit"))
                    {
                        TypingStyle.TypeText("Bot: Goodbye! Stay safe online!");
                        break;
                    }
                    else if (userInput.Contains("how are you"))
                    {
                        TypingStyle.TypeText("Bot: I'm running perfectly and ready to help you stay safe online!");
                    }
                    else if (userInput.Contains("purpose"))
                    {
                        TypingStyle.TypeText("Bot: My purpose is to teach people about cybersecurity awareness.");
                    }
                    else if (userInput.Contains("password"))
                    {
                        TypingStyle.TypeText("Bot: Use strong passwords with letters, numbers and symbols.");
                    }
                    else if (userInput.Contains("phishing"))
                    {
                        TypingStyle.TypeText("Bot: Phishing is when attackers trick you into giving personal information through fake emails or websites.");
                    }
                    else if (userInput.Contains("safe browsing"))
                    {
                        TypingStyle.TypeText("Bot: Only visit trusted websites and avoid clicking suspicious links.");
                    }
                    else

                    {
                        TypingStyle.TypeText("Bot: I didn't quite understand that. Could you rephrase?");
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
