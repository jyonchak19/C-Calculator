// See https://aka.ms/new-console-template for more information
int aNumber = 0, anotherNumber = 0;
Boolean exit = false;

// title
Console.WriteLine("Welcome to console calculator\r");
Console.WriteLine("-----------------------------\n");
Console.WriteLine("-----------------------------\n");

while (!exit)
{
    // get first number from user
    Console.WriteLine("Type a number and then press enter\r");
    aNumber = Convert.ToInt32(Console.ReadLine());

    // get second number from user
    Console.WriteLine("Type another number and then press enter\r");
    anotherNumber = Convert.ToInt32(Console.ReadLine());

    // ask user to select an option (multiply, divide, subtract, add)
    Console.WriteLine("");
    Console.WriteLine("Enter +, -, *, /");
    switch (Console.ReadLine())
    {
        case "+":
            Console.WriteLine($"Your result is: {aNumber} + {anotherNumber} = " + (aNumber + anotherNumber));
            break;
        case "-":
            Console.WriteLine($"Your result is: {aNumber} - {anotherNumber} = " + (aNumber - anotherNumber));
            break;
        case "*":
            Console.WriteLine($"Your result is: {aNumber} * {anotherNumber} = " + (aNumber * anotherNumber));
            break;
        case "/":
            Console.WriteLine($"Your result is: {aNumber} / {anotherNumber} = " + (aNumber / anotherNumber));
            break;
    }

    // ask user if they would like to exit or continue
    Console.WriteLine("Exit? y or any key to continue");
    if (Console.ReadLine() == "y")
        exit = true;
}
