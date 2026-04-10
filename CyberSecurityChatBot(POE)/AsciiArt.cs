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
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("============================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("============================================");
            Console.WriteLine(@"
||          _(,__           __),          ||
||     (_,d888888888b,d888888888b         || 
||      d888888888888/888888888888b_)     ||
||    (_8888888P'""""'`Y8Y`'""""'""Y88888      ||
||     Y8888P.-'     `      '-.Y8888b_)   ||
||    ,_Y88P (_(_(        )_)_) d88Y_,    ||
||     Y88b,  ( o )      ( o ) d8888P     ||
||     `Y888   '-'        '-'  `88Y`      ||
||     ,d/O\         c         /O\b,      ||
||       \_/'.,______w______,.'\_/        ||
||                                        ||
||                                        ||");
            Console.WriteLine("===========================================");


            Console.ResetColor();
        }
    }
}

