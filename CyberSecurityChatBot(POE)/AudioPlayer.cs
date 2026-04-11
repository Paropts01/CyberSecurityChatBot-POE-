using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
     public class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.PlaySync();
            }
            catch
            {
                // If file not found
                System.Console.WriteLine("Audio greeting could not be played.");
            }
        }

    }
}
