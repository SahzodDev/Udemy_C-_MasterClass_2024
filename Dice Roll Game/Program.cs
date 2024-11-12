

using Dice_Roll_Game;
using System.Security.Cryptography;

Random rnd = new Random();
Dice dice = new Dice(rnd);
UserInputAccepter userInputAccepter = new UserInputAccepter();
DiceRollChecker diceRollChecker = new DiceRollChecker(userInputAccepter, dice);
UserMessageProvider userMessageProvider = new UserMessageProvider(userInputAccepter);



try
{
    dice.RollDice();
    Console.WriteLine("Dice is rolled.");
    while (userInputAccepter.InputCount < 3)
    {
        
        Console.Write("Please enter your guess:");

        try
        {
            userInputAccepter.Accept(Console.ReadLine().ToString());
        } catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }
        
        diceRollChecker.Check();
        userMessageProvider.GiveMessage(diceRollChecker.IsDiceNumberCorrect);
        Console.WriteLine(userMessageProvider.Message);

        if (diceRollChecker.IsDiceNumberCorrect)
        {
            break;
        }
    }
    

} catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}

Console.ReadKey();
