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
            //this method is responsible for initiating the chatbot session, greeting the user, and guiding them through the available topics. It also handles user input validation and manages the main chat loop where the user can interact with the chatbot until they choose to exit.
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                // HEADER
                Console.WriteLine("=============================================================");
                Console.WriteLine("                   WELCOME TO YOUR SESSION                   ");
                Console.WriteLine("=============================================================");

                Console.ForegroundColor = ConsoleColor.Magenta;
                TypingStyle.TypeText("\nBot: What is your name? ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                TypingStyle.TypeText("\nYou: ");
                UserName = Console.ReadLine();

                // UserInput validation which assigns "anonymous" if the user does not enter a name or enters only whitespace
                if (string.IsNullOrWhiteSpace(UserName))
                {
                    UserName = "anonymous";
                }
                // WELCOME MESSAGE that includes the user's name and instructions on how to use the chatbot
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypingStyle.TypeText($"\nWelcome {UserName} to our session, if it is your first time here ");
                TypingStyle.TypeText($"\n-> Type 'help' to see what you can ask me.");
                TypingStyle.TypeText($"\n-> Type 'exit' to quit.");
                Console.WriteLine("--------------------------------------------------------------");

                Console.ForegroundColor = ConsoleColor.Magenta;
                TypingStyle.TypeText($"\nBot: What would you like to talk about today {UserName}?.\n");

                // chat is the main loop of the chatbot, where it continuously listens for user input and responds accordingly until the user decides to exit the chat
                ChatLoop();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error starting chatbot! " + ex.Message);
            }
        }
        // The ChatLoop method is responsible for continuously listening for user input, processing it, and providing appropriate responses based on the user's queries. It handles various topics related to cybersecurity and ensures that the user can exit the chat gracefully when they choose to do so.
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
                    TypingStyle.TypeText("\n You: ");
                    userInput = Console.ReadLine();

                    // Empty input validation to ensure that the user provides a valid question or command. If the input is empty or consists only of whitespace, the chatbot prompts the user to enter a valid question instead of processing an empty input.
                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        TypingStyle.TypeText($"\n Bot: {UserName}, I didn’t quite catch that. Could you please enter a valid question?");
                        continue;
                    }

                    userInput = userInput.ToLower();

                    // EXIT COMMAND that allows the user to end the chat session. When the user types "exit", the chatbot responds with a farewell message and breaks out of the chat loop, effectively ending the session.
                    if (userInput.Contains("exit"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\n Bot: It was a pleasure assisting you today, {UserName}. Stay safe online and take care!");
                        break;
                    }

                    // HELP / WHAT CAN I ASK COMMAND that provides the user with a list of available topics they can ask about. When the user types "help" or "what can I ask", the chatbot responds with a list of cybersecurity topics and encourages the user to ask questions related to those topics for further guidance and advice.
                    else if (userInput.Contains("help") || userInput.Contains("what can i ask"))
                    {
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("\n====================== AVAILABLE TOPICS =====================");
                        Console.WriteLine("-> Password safety");
                        Console.WriteLine("-> Phishing attacks");
                        Console.WriteLine("-> Safe browsing");
                        Console.WriteLine("-> Chatbot's purpose");
                        Console.WriteLine("=============================================================");

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\nBot: Great to ask for help, {UserName}! You can ask me about any of these topics,\nand I’ll guide you with practical advice to help you stay safe in\nthe digital world.");
                    }

                    else if (userInput.Contains("how are you"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\n Bot: I’m functioning optimally, thank you for asking, {UserName}.\nI’m here and ready to assist you with any\ncybersecurity concerns you may have.");
                    }

                    else if (userInput.Contains("purpose"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\n Bot: My purpose is to empower you, {UserName}, with essential cybersecurity knowledge.\nI aim to help you understand risks, recognise threats,\n and make safer decisions while using the internet.");
                    }

                    else if (userInput.Contains("password"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\n Bot: That’s an excellent topic, {UserName}. A strong password is your\nfirst line of defence against cyber threats.\n" +
                                             "Make sure your passwords are long, unique, and include a\n combination of uppercase letters, lowercase letters, numbers,\nand special characters." +
                                             "\nAvoid using personal information, and consider using a password\n manager to securely store your credentials.");
                    }

                    else if (userInput.Contains("phishing"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\n Bot: That’s a very important topic, {UserName}.\n Phishing is a cyber attack where criminals try to\n trick you into revealing sensitive information such as passwords\n or banking details.\n" +
                                             "These attacks often appear as emails or messages from\ntrusted organisations. Always verify the sender,\navoid clicking suspiciouslinks, and never share personal information\nunless you are certain the source is legitimate.");
                    }

                    else if (userInput.Contains("safe browsing"))
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        TypingStyle.TypeText($"\n Bot: Staying safe while browsing is essential, {UserName}.\nAlways ensure that websites are secure (look for HTTPS in the URL),\n avoid downloading files from unknown sources, and be cautious\n when entering personal information online.\n" +
                                             "Keeping your browser and antivirus software updated also plays\na key role in protecting your data.");
                    }
                    // VALIDATION FOR UNKNOWN TOPICS
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        TypingStyle.TypeText($"\n Bot: That’s an interesting question, {UserName}.\n I may not have a direct answer for that just yet.\n" +
                                             "However, I can assist you with topics like password security,\nphishing awareness, and safe browsing practices.\n" +
                                             "Type 'help' to explore what I can assist you with.");
                    }
                }
                catch (Exception ex)// This catch block is designed to handle any unexpected errors that may occur during the chat loop, such as issues with user input or other runtime exceptions. If an error occurs, it will display an error message in red, informing the user that the bot has failed to launch and suggesting that they try relaunching it again.
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error:Bot has failed to launch! Relaunch again. " + ex.Message);
                }
            }
        }
    }
}
