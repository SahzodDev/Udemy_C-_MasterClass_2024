using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roll_Game
{
    public class Dice
    {
        Random _random;
        public Dice(Random random)
        {
            _random = random;
        }
        public int RolledNumber { get; private set; }
        public void RollDice() 
        {
            RolledNumber = _random.Next(0, 7);
        }
    }
}
