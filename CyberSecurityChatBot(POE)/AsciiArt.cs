using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    public class AsciiArt
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("=======================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("=======================================");

            Console.WriteLine(@"
        [  CYBER  BOT  ]
          |  |  |  |
         (  O  O  )
        --|  --  |--
           |____|
         /  |  |  \
        Secure Your Data
            ");

            Console.ResetColor();
        }
    }
}

