# Coolio
Simpler IO features for C# console applications.

# Features
Coolio includes a few features, based off the two base concepts:

## print(message, type)
print prints text to the screen using ``` Console.WriteLine ``` and ``` Console.Write ```. 

The first argument {message} is the message you want to be displayed. Message must be a string.\
The second argument {type} is the way that the text is displayed. Types and their uses are listed below:

0 = automatically jumps to the next line
1 = require keypress to return to next line
       
## input(message, type)
input prints a message using ``` Console.WriteLine ``` and ``` Console.Write ```, and reads input using ``` Console.ReadLine ```.

The first argument {message} is the message you want to be displayed, this will be presented before the input. Message must be a string.\
The second argument {type} is the way that the text is displayed and input is requested. Types and their uses are listed below:

0 = keeps input on the same line as the message
1 = puts the input below the message

# Using Coolio
Just download the [source code](https://github.com/windingtheropes/coolio/archive/main.zip "main.zip") and add coolio.cs into your project.\
Coolio can be simply implemented like in the code snippet below.

```
using System;
using coolio;

namespace coolio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Import coolio
            coolio coolio = new coolio();
            
            //Print "Hello"
            coolio.print("Hello", 0);
            
            //Ask for input with the prompt "What is your name?"
            string name = coolio.input("What is your name? ", 0);
            coolio.print(name, 0);
        }
    }
}

```
