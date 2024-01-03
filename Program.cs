// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, Welcome to my verb project!");
Console.WriteLine("Enter a verb!");
string verbentered;
verbentered = Console.ReadLine();
Console.WriteLine("You have entered: "+ verbentered);
validateVerb(verbentered);


     static void validateVerb(string i)
    {
        // vbisvalid = true;
        string ending = i.Substring(i.Length -2);
        switch(ending) 
    {
    case "ar":
        Console.WriteLine("Its an AR verb.");
        break;
    case "er":
        Console.WriteLine("Its an ER verb.");
        break;
    case "ir":
        Console.WriteLine("Its an IR verb.");
        break;
    default:
        Console.WriteLine("Not a verb.");
        // vbisvalid = false;
        break;
        }
    }