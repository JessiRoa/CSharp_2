using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorytellerLib
{
    public class Storyteller
    {
        //public string myStory;

        public string TellStory(string nameOfChild, int ageOfChild, bool willBeScary)
        {
            if (ageOfChild < 5 && willBeScary)
                throw new InvalidOperationException();
            string myStory = "";
                if (ageOfChild < 7)
            {
                myStory += $"Lyssna nu { nameOfChild}. Det var en gång en prinsessa";
            }
             else
                myStory += $"Hallå {nameOfChild}! En gång fanns en kille ";
             
            string scary = "";
            if (!willBeScary)
            {
                scary += "som tyckte om att dansa.";
            }
            else
                scary += "som egentligen var en varulv.";


            return myStory + scary;
        }
    }
}
