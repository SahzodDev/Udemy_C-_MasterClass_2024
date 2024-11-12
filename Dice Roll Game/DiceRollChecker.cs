using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll_Game
{
    public class DiceRollChecker
    {
        UserInputAccepter _userInputAccepter;
        Dice _dice;
        public DiceRollChecker(UserInputAccepter userInputAccepter, Dice dice)
        {
            _userInputAccepter = userInputAccepter;
            _dice = dice;
        }

        public bool IsDiceNumberCorrect { get; private set; }

        public void Check()
        {
            if (_userInputAccepter.UserInput == _dice.RolledNumber)
            {
                IsDiceNumberCorrect = true;
            }
            else 
            {
                IsDiceNumberCorrect = false;
            }
        }
    }
}
