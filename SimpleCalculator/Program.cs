

int TakeUserInput(int inputOrder)
{
    Console.WriteLine($"Please provide the {inputOrder}. input: ");
    return int.Parse(Console.ReadLine());
}

string TakeUserOperation()
{
    Console.WriteLine("What do you want to do with these numbers?\n" +
                      "[A]dd\n" +
                      "[S]ubtract\n" +
                      "[M]ultiply");
    string userInput = Console.ReadLine();
    if (userInput.ToUpper() == "A" || userInput.ToUpper() == "S" || userInput.ToUpper() == "M")
    {
        return userInput;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
        return TakeUserOperation();
    }
}


int Add(int num1, int num2)
{
    return num1 + num2;
}

int Subtract(int num1, int num2)
{
    return num1 - num2;
}

int Multiply(int num1, int num2)
{
    return num1 * num2;
}

int PerformOperation(int num1, int num2, string operation)
{
    if (operation.ToUpper() == "A")
    {
        return Add(num1, num2);
    }
    else if (operation.ToUpper() == "S")
    {
        return Subtract(num1, num2);
    }
    else
    {
        return Multiply(num1, num2);
    }
}

void PrintResult(int input1, int input2, int result, string operation)
{
    if (operation.ToUpper() == "A")
    {
        Console.WriteLine($"{input1} + {input2} = {result}");
    }
    else if (operation.ToUpper() == "S")
    {
        Console.WriteLine($"{input1} - {input2} = {result}");
    }
    else
    {
        Console.WriteLine($"{input1} * {input2} = {result}");
    }
}

void PressAnyKeyToExit()
{
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

int input1 = 0;
int input2 = 0;
string operation = string.Empty;

for (int i = 1; i <= 2; i++)
{
    int userInput = TakeUserInput(i);
    if (i == 1)
    {
        input1 = userInput;
    }
    else
    {
        input2 = userInput;
    }
}

operation = TakeUserOperation();

int result = PerformOperation(input1, input2, operation);

PrintResult(input1, input2, result, operation);

PressAnyKeyToExit();