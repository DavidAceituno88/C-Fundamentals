// See https://aka.ms/new-console-template for more information
//
using System.Reflection;
// If statement
Console.WriteLine("Uncle Dave Giveaway!");
Console.WriteLine("Choose a Door: 1, 2 or 3: ");
string userValue = Console.ReadLine();

/* Using the traditional if, else, else if

string message = "";

if(userValue == "1")
    {
        message ="You won a Xbox";
    }

else if (userValue == "2")
    {
        message = "You won a toilet";
    }
else if (userValue == "2")
    {
        message = "You won a dead fish";
    }
else
    {
        message = "Sorry we didn't understand. ";
        message += "You lose.";
    }
Console.Write(message);
Console.ReadLine();

 */

//Using the ternary operator (short hand)
string message = (userValue == "1") ? "Xbox" : "set of 10 burpees";

Console.Write("You won a : {0}.", message );
Console.ReadLine();
