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
            AudioPlayer player = new AudioPlayer();
            player.PlayGreeting();
        }
    }
}
