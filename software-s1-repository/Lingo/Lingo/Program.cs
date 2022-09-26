using System;
using System.IO;

namespace Lingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalWoorden = 12738;
            Console.WriteLine("6 letter woorden, kleine letter is andere locatie, hoofdletter is juiste locatie");

            // put textfile in array
            string[] lines = File.ReadAllLines("5-LetterWoorden.txt");

            // random getal van 0 tot 801
            int randomLine = RandomNumber(0, aantalWoorden + 1);

            // pak het woord op die alinea
            string randomWord = lines[randomLine];

            // pak eerste letter van random woord
            string gok = lines[randomLine].Substring(0, 1).ToUpper();

            // display eerste letter van random woord
            Console.WriteLine(gok + " _ _ _ _ _");

            while (gok != randomWord)
            {
                gok = "";
                while (gok.Length != 6)
                {
                    gok = Console.ReadLine();
                }

                bool woordBestaat = false;

                for (int i = 0; i < aantalWoorden; i++)
                {
                    if (gok == lines[i])
                    {
                        woordBestaat = true;
                    }
                }

                if (woordBestaat)
                {

                    string test = "";

                    for (int i = 0; i < 6; i++)
                    {
                        if (gok.Substring(i, 1) == randomWord.Substring(i, 1))
                        {
                            test += gok.Substring(i, 1).ToUpper();
                        }
                        else if (gok.Substring(i, 1) == randomWord.Substring(1, 1) || gok.Substring(i, 1) == randomWord.Substring(2, 1) || gok.Substring(i, 1) == randomWord.Substring(3, 1) || gok.Substring(i, 1) == randomWord.Substring(4, 1) || gok.Substring(i, 1) == randomWord.Substring(5, 1))
                        {
                            test += gok.Substring(i, 1).ToLower();
                        }
                        else
                        {
                            test += "_";
                        }
                        test += " ";
                    }

                    Console.WriteLine(test);
                }
                else
                {
                    Console.WriteLine("Woord bestaat niet");
                }
            }
        }

        static int RandomNumber(int firstNumber, int lastNumber)
        {
            Random rng = new Random();
            int randomLine = rng.Next(firstNumber, lastNumber);

            return randomLine;
        }
    }
}

/*
 to do
letters moeten toupper op goede plek
letters moeten klein op foute plek
cw gok moet niet hardcoded zijn
  
 
 */