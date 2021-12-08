using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable
namespace CSCodeAnalysis;

// Alt+Enter on MiddleName, change to string?
record Person(string FirstName, string LastName, string MiddleName = null);

public class HelloWorld
{
    public void SayHello(string name)
    {
        // Alt+Enter on the next line, make parameter nullable
        if (name == null)
        {
            Console.WriteLine("Hello! 👋");
        }
        else
        {
            Console.WriteLine($"Hello, {name}! 👋");
        }
    }
}