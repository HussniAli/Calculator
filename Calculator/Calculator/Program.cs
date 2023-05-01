
// Ask user to input two numbers
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

// Display menu of available operations
Console.WriteLine("Available operations:");
Console.WriteLine(" Addition (+)");
Console.WriteLine(" Subtraction (-)");
Console.WriteLine(" Multiplication (*)");
Console.WriteLine(" Division (/)");

// Ask user to choose an operation
Console.Write("\nEnter the operation you want to perform: ");
string operation = Console.ReadLine();

double result = 0;

// Perform the chosen operation
switch (operation)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        if (num2 != 0)
        {
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("\nCannot divide by zero!");
            return;
        }
        break;
    default:
        Console.WriteLine("\nInvalid operation!");
        return;
}

// Display the result
Console.WriteLine($"\n{num1} {operation} {num2} = {result}");
