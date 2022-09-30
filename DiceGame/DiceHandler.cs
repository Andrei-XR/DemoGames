using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class DiceHandler
    {
        private Dice Dice { get; set; }
        public int DiceAmount { get; set; }
        public int Result { get; private set; }

        public void PlayDices()
        {
            Result = 0;

            for (int i = 0; i < DiceAmount; i++)
            {
                Result += GenerateRandomNumber();
            }

        }

        private int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, Dice.NumberPositions);
        }
    }
}
