using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    internal class CyberSecurityChatBot : Chatbot
    {

        public override void StartChat() // Polymorphism
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

        private void ChatLoop()
        {
            string userInput;

            // Nullable array of topics
            string[] topics =
            {
                "password",
                "phishing",
                "safe browsing"
            };

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\nYou: ");
                userInput = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: Please enter a valid question.");
                    continue;
                }

                if (userInput.Contains("exit"))
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online!");
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
        }
    }
}
