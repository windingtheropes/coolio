# coolio
Simpler IO features for C# console applications.

# use

```
using System;
using coolio;

namespace coolio
{
    class Program
    {
        static void Main(string[] args)
        {
            coolio coolio = new coolio();

            coolio.print("Hello", 0);

            string name = coolio.input("What is your name? ", 0);
            coolio.print(name, 0);
        }
    }
}

```
