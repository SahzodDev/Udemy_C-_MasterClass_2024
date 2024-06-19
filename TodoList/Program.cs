

void ShowWelcomeMessage()
{
    Console.WriteLine("Hello!\n" +
                      "What do you want to do?\n" +
                      "[S]ee all TODOs\n" +
                      "[A]dd a TODO\n" +
                      "[R]emove a TODO\n" +
                      "[E]xit");
}

string GetMenuInput()
{
    Console.WriteLine("Enter your choice:");
    string userInput = Console.ReadLine().ToUpper();
    return userInput;
}

bool IsValidMenuInput(string userInput)
{
    return userInput == "S" || userInput == "A" || userInput == "R" || userInput == "E";
}

void ShowErrorMessage()
{
    Console.WriteLine("Invalid input. Please try again.");
}

string MenuInput()
{
    string userInput;

    ShowWelcomeMessage();

    do
    {
        userInput = GetMenuInput();
        if (!IsValidMenuInput(userInput))
        {
            ShowErrorMessage();
        }
    } while (!IsValidMenuInput(userInput));
    return userInput;
}

void AddTodo(List<string> todos)
{
    Console.WriteLine("Enter the task:");
    string task = Console.ReadLine();
    if (!IsUniqueTodo(todos, task))
    {
        todos.Add(task);
        Console.WriteLine("Task added succesfully.");
    }
    else
    {
        Console.WriteLine("This task already exists.");
    }
}

bool IsUniqueTodo(List<string> todos, string task)
{
    return todos.Contains(task);
}

void ShowTodos(List<string> todos)
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No tasks.");
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }
    }
}

void RemoveTodo(List<string> todos)
{
    ShowTodos(todos);
    if (todos.Count > 0)
    {
        Console.WriteLine("Enter the number of the task you want to remove:");
        bool isNumber = int.TryParse(Console.ReadLine(), out int taskNumber);
        if (isNumber && taskNumber > 0 && taskNumber <= todos.Count)
        {
            todos.RemoveAt(taskNumber - 1);
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
}

void Main()
{
    List<string> todos = new List<string>();

    string userInput;
    do
    {
        userInput = MenuInput();
        switch (userInput)
        {
            case "S":
                ShowTodos(todos);
                break;
            case "A":
                AddTodo(todos);
                break;
            case "R":
                RemoveTodo(todos);
                break;
        }
    } while (userInput != "E");
}

Main();