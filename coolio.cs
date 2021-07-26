//coolio created by windingtheropes
using System;
using System.Collections.Generic;
using System.Text;

namespace coolio
{
    class coolio
    {
     
        public void print(string message, int type = 0)
        {
            switch(type)
            {
                case 0:
                    Console.WriteLine(message);
                    break;
                case 1:
                    Console.Write(message);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
           

        }
     
        public string input(string message, int type = 0)
        {
            switch(type)
            {
                case 0:
                    Console.Write(message);
                    return Console.ReadLine().ToString();
                    break;
                case 1:
                    Console.WriteLine(message);
                    return Console.ReadLine().ToString();
                    break;
                default:
                    Console.WriteLine("Error");
                    return null;
                    break;
            }
        }


    }
}
