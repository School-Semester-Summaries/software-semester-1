using System;
using System.Collections.Generic;
using System.Text;

namespace AstroBlastr_Side_Program
{
    class Speler
    {
        // Fields
        static private int score = 0;
        static private int coins = 0;
        static private int experiencePoints = 0;

        // Properties
        public int Score { get { return score; } }
        public int Coins { get { return coins; } }
        public int ExperiencePoints { get { return experiencePoints; } }

        // Constructor
        public Speler()
        {
            score = 0;
            coins = 0;
            experiencePoints = 0;
        }

        // Methods
        public void AddPointToScore(int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                score++;
            }
        }

        public void AddCoinToCoins(int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                coins++;
            }
        }

        public void AddExperienceToExperiencePoints(int repetitions)
        {
            for (int i = 0; i < repetitions; i++)
            {
                experiencePoints++;
            }
        }
    } // Speler
}
