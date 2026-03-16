using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    public class Chatbot
    {
        // Encapsulation
        private string userName = "";

        // Property
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        // Virtual method for polymorphism
        public virtual void StartChat()
        {
            Console.WriteLine("Chatbot starting...");
        }
    }
}

