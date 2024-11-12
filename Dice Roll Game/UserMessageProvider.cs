using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll_Game
{
    public class UserMessageProvider
    {
        UserInputAccepter _accepter;
        public UserMessageProvider(UserInputAccepter accepter)
        {
            _accepter = accepter;
        }

        public string Message { get; set; }

        public void GiveMessage(bool diceResult)
        {
            if (_accepter.InputCount < 3)
            {
                if (diceResult == true)
                {
                    Message = "You win";

                }
                else if (diceResult == false)
                {
                    Message = "Wrong number";
                }
            }   
            else
            {
                Message = "You lose";
            }

            

        }
    }
}
