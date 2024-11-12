using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll_Game
{
    public class UserInputAccepter
    {
        public int UserInput { get; set; }
        public int InputCount { get; private set; }
        public void Accept(string userInput) 
        {
            if (ValidateUserInput(userInput))
            {
                int userInputNumber = int.Parse(userInput);
                UserInput = userInputNumber;
                CountUserInput();
            }
            else 
            {
                throw new ArgumentException("Invalid user input.");
            }
            
        }

        public void CountUserInput() 
        {
            InputCount++;
        }

        public bool ValidateUserInput(string userInput) 
        {

            bool isInteger = int.TryParse(userInput, out int number);

            if (isInteger && number > 0 && number <= 6)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
