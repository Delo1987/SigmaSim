using System;
using Android.Renderscripts;

namespace SigmaSim.Classes
{
    class Dice
    {
        private readonly Random rand;

        public Dice()
        {
            rand = new Random();
        }

        public int GenerateD3()
        {
            return rand.Next(1, 3);
        }

        public int GenerateD6()
        {
            return rand.Next(1, 6);
        }
    }
}