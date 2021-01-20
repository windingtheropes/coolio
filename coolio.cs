//coolio created by windingtheropes
using System;
using System.Collections.Generic;
using System.Text;

namespace coolio
{
    class coolio
    {
     
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
