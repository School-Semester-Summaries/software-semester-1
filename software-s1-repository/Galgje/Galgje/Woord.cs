using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    class Woord
    {
        // Objects
        Random rnd = new Random();

        // Fields
        private string word;

        // Methods die objecten aanmaken
        public string RandomWord()
        {
            string[] lines = { "tas", "rok", "pas", "doek", "klas", "bord" };
            // random getal van 0 tot aantal woorden
            int randomLine = rnd.Next(0, lines.Length);
            // pak het woord op die alinea
            string randomWord = lines[randomLine];

            return randomWord;
        }
        public string RandomWord(int letters)
        {
            if (letters == 3)
            {
                Woord woord = new Woord(3);
                return woord.word;
            }
            else if (letters == 4)
            {
                Woord woord = new Woord(4);
                return woord.word;
            }
            else
            {
                Woord woord = new Woord();
                return woord.word;
            }
        }

        // Constructors
        public Woord()
        {
            RandomWord();
        }
        public Woord(int Letters)
        {
            if (Letters == 3)
            {
                word = Random3LetterWord();
            }
            else if (Letters == 4)
            {
                word = Random4LetterWord();
            }
        }

        // Methods
        public string Random3LetterWord()
        {
            string[] lines = { "TAS", "ROK", "PAS"};
            // random getal van 0 tot aantal woorden
            int randomLine = rnd.Next(0, lines.Length);
            // pak het woord op die alinea
            string randomWord = lines[randomLine];

            return randomWord;
        }
        public string Random4LetterWord()
        {
            string[] lines = {"DOEK", "KLAS", "BORD" };
            // random getal van 0 tot aantal woorden
            int randomLine = rnd.Next(0, lines.Length);
            // pak het woord op die alinea
            string randomWord = lines[randomLine];

            return randomWord;
        }
    }
}
