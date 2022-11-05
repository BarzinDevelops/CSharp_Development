// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
bool proceed = true;

bool getUserChoise()
{
    
    try
    {
        Console.Write($"Would you like to proceed? (y or n) => ");
        char userChoise = Convert.ToChar(Console.ReadLine());
        if (userChoise == 'y' || userChoise == 'n')
        {
            proceed = (userChoise == 'y') ? true : false;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nYou're input was invalid! {ex.Message}\n\nTry again, enter only 'y' or 'n' !!!");
        getUserChoise();
    }

   return proceed;
}



void addTwoNumbers()
{
    try
    {
        
        Console.WriteLine($"Enter your first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Enter your second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"Result of {num1} + {num2} = {result}");
        Console.WriteLine($"\n=============================================================\n");
        proceed = getUserChoise();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"\nYou're input was invalid! {ex.Message}\n\nTry again!");
        addTwoNumbers();
    }
}


do
{
    Console.WriteLine("This application adds the two numbers you provide.");
    addTwoNumbers();
   
} while (proceed);


