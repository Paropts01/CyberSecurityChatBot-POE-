using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatBot_POE_
{
    public class Chatbot
    {
        // Encapsulation - private field with public property
        private string userName = "";

        
        public string UserName// Property to access the private field
        {
            get { return userName; }// Getter returns the value of userName
            set { userName = value; }// Setter assigns a value to userName
        } 
    }
}

