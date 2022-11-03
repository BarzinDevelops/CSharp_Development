// See https://aka.ms/new-console-template for more information

// Declare Variable
/*
    Data types
    string - words/numbers (Name, license plate number) - "Trevoir", "Hello World"
    int - whole numbers | double/float - decimals
    char - One Character ('A', '7', '%')
 */


// AllowNullAttribute user input and store in variable
Console.Write("What is your name? ");
string fullName = Console.ReadLine();

// Print contents of variable/user's input
Console.WriteLine($"Hi {fullName}, nice to meet your");