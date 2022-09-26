using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    class Gok
    {
        // Objects
        Speler speler = new Speler();

        // Fields
        private string displayOld = "";

        // Methods
        public string CheckIfWordContainsLetter(List<string> listItems, string woord, string letter)
        {
            string display = "";
            for (int i = 0; i < woord.Length; i++)
            {
                if (letter == woord.Substring(i, 1))
                {
                    display += letter + " ";
                }
                else if (listItems.Contains(woord.Substring(i, 1)))
                {
                    for (int j = 0; j < listItems.Count; j++)
                    {
                        if (listItems[j] == woord.Substring(i, 1))
                        {
                            display += listItems[j] + " ";
                        }
                    }
                }
                else
                {
                    display += "_ ";
                }

                if (displayOld == display)
                {
                    speler.RemoveLife();
                    if (speler.CheckIfDead())
                    {
                        display = "LOSER";
                    }
                }
            }
            displayOld = display;
            return display;
        }
        public void PutGokInList(List<string> listItems , string gok)
        {
            if (!listItems.Contains(gok) && gok.Length > 0)
            {
                listItems.Add(gok);
            }
        }
    }
}
