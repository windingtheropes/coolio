using System;
using System.Collections.Generic;
using System.Text;

namespace coolio
{
    class coolio
    {
        //2021 coolio for c# applications created by windingtheropes
        //cooliomakes IO parts of console apps easier to use
        //see documentation above functions for more specific information

        //prints text
        //types:
        //0 = automatically jumps to the next line
        //1 = require keypress to return to next line
        public void print(string message, int type)
        {
            if (type == 0)
            {
                Console.WriteLine(message);
            }
            else if (type == 1)
            {
                Console.Write(message);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
        //gets user input, with a set message. automatically adds a space between your message and the text input. 
        //types:
        //0 = input: type here
        //1 = input:
        //    type here
        public string input(string message, int type)
        {
            if (type == 0)
            {
                Console.Write(message);
                return Console.ReadLine().ToString();
            }
            else if (type == 1)
            {
                Console.WriteLine(message);
                return Console.ReadLine().ToString();
            }
            else
            {
                Console.WriteLine("Error");
                return null;
            }
        }


    }
}
