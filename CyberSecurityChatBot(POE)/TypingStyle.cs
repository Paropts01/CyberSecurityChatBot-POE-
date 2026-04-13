using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    public class TypingStyle
    {
        // Method that prints text slowly (typing animation)
        public static void TypeText(string message)
        {
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(30); // speed of typing (milliseconds)
            }

            Console.WriteLine();
        }

    }
}

