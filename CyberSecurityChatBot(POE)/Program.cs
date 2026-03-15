using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Display ASCII logo
            AsciiArt.DisplayLogo();

            AudioPlayer player = new AudioPlayer();
            player.PlayGreeting();
        }
    }
}
