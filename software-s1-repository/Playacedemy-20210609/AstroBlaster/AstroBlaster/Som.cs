using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroBlaster
{
    public class Som
    {

        static bool numbersToTwenty;
        static bool noZero;
        static int randomNumber1;
        static int randomNumber2;
        string sum;
        int answer;

        // create random object
        Random rng = new Random();

        // kiest willekeurig welke som gevraagd gaat worden
        public string GenerateRandomSom()
        {
            int randomSom = rng.Next(1, 5);

            // welke soort som
            if (randomSom == 1)
            {
                numbersToTwenty = false;
                sum = GenerateKeersom();
            }
            else if (randomSom == 2)
            {
                numbersToTwenty = false;
                noZero = true;
                sum = GenerateDeelsom();
                noZero = false;
            }
            else if (randomSom == 3)
            {
                numbersToTwenty = true;
                sum = GenerateOptelsom();
            }
            else if (randomSom == 4)
            {
                numbersToTwenty = true;
                sum = GenerateAftreksom();
            }
            return sum;
        }

        // genereert een random keersom en stopt 'm in een string
        private string GenerateKeersom()
        {
            // 2 random nummer krijgen
            randomNumber1 = RandomNumber();
            randomNumber2 = RandomNumber();

            // definier antwoord
            answer = randomNumber1 * randomNumber2;

            // maak hier een optelsom van en stuur het terug
            sum = randomNumber1 + " x " + randomNumber2;
            return sum;
        }

        // genereert een random deelsom en stopt 'm in een string
        private string GenerateDeelsom()
        {
            // 2 random nummer krijgen
            randomNumber1 = RandomNumber();
            randomNumber2 = RandomNumber();

            // definier antwoord
            answer = randomNumber1 * randomNumber2 / randomNumber2;

            // maak hier een optelsom van en stuur het terug
            sum = randomNumber1 * randomNumber2 + " / " + randomNumber2;
            return sum;
        }

        // genereert een random optelsom en stopt 'm in een string
        private string GenerateOptelsom()
        {
            // 2 random nummer krijgen
            randomNumber1 = RandomNumber();
            randomNumber2 = RandomNumber();

            // definier antwoord
            answer = randomNumber1 + randomNumber2;

            // maak hier een optelsom van en stuur het terug
            sum = randomNumber1 + " + " + randomNumber2;
            return sum;
        }

        private string GenerateAftreksom()
        {
            // 2 random nummer krijgen
            randomNumber1 = RandomNumber();
            randomNumber2 = RandomNumber();

            // zorg ervoor dat het grote getal eerst komt om mingetallen te vermijden
            if (randomNumber1 > randomNumber2)
            {
                // definier antwoord
                answer = randomNumber1 - randomNumber2;

                // maak hier een aftreksom van en stuur het terug
                sum = randomNumber1 + " - " + randomNumber2;
            }
            else if (randomNumber1 < randomNumber2 || randomNumber1 == randomNumber2)
            {
                // definier antwoord
                answer = randomNumber2 - randomNumber1;

                // maak hier een aftreksom van en stuur het terug
                sum = randomNumber2 + " - " + randomNumber1;
            }
            return sum;
        }

        // het antwoord van de som in een int // property fix dit!!
        public int GetAnswer()
        {
            return answer;
        }
        
        // randomised een getal en returnt het
        private int RandomNumber()
        {
            int number;
            if (numbersToTwenty)
            {
                number = rng.Next(0, 21);
            }
            else if (noZero)
            {
                number = rng.Next(1, 11);
            }
            else
            {
                number = rng.Next(0, 11);
            }
            return number;
        }

        public int GetFakeAnswer()
        {
            
            double FakeAnswer;
            double Realanswer = Convert.ToDouble(GetAnswer());
            int PlusMin = rng.Next(0, 6);

            
            FakeAnswer =    (PlusMin == 0) ?    (Realanswer + ((Realanswer / 90) * 10)) :
                            (PlusMin == 1) ?    (Realanswer + ((Realanswer / 80) * 10)) :
                            (PlusMin == 2) ?    (Realanswer - ((Realanswer / 90) * 10)) :
                            (PlusMin == 3) ?    (Realanswer - ((Realanswer / 80) * 10)) :
                            (PlusMin == 4) ?    (Realanswer + ((Realanswer / 50) * 10)) :
                                                (Realanswer - ((Realanswer / 50) * 10)) ;
            return Convert.ToInt32(FakeAnswer);
        }

    } // Som
}
