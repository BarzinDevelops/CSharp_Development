// See https://aka.ms/new-console-template for more information

//Variable Declarations and Types:

using System.Globalization;
//Console.OutputEncoding = System.Text.Encoding.UTF8;

string fullName = string.Empty;
int age;
double salary;
char gender = char.MinValue;
bool isWorking;

// Prompt User for Input!

Console.Write($"Please enter your name: ");
fullName = Console.ReadLine();

Console.Write($"Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write($"Please enter your monthley salary: € ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write($"Please enter your gender (F or M): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write($"You are working at this moment (true or false): ");
isWorking = Convert.ToBoolean(Console.ReadLine());



// Print the information based on the input:
Console.WriteLine("\n\n============================================\n\n");

Console.WriteLine($"Hi {fullName}, we have collected the following info based on your input:" +
    $"\nYou're age is => {age}," +
    $"\nYou're monthley salary is => €{salary}," +
    $"\nYou're gender is => {gender}," +
    $"\n{(isWorking ? "You're employed at this time" : "You're currentley unemployed")}");

Console.WriteLine("\n\n============================================\n\n");
CultureInfo culture1 = CultureInfo.CurrentCulture;
Console.WriteLine("The current culture is {0} -> {1}", culture1.Name, culture1.DisplayName);
CultureInfo uiCulture2 = CultureInfo.CurrentUICulture;
Console.WriteLine("The current UI culture is {0} -> {1}\n", uiCulture2.Name, culture1.DisplayName);