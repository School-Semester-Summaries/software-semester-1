using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Dialogue
    {
        public string AmogusBlue(bool firstTimeInteracting, bool key)
        {
            string text;
            if (firstTimeInteracting)
            {
                text = "Hey buddy. Look at the right of your screen. That's your inventory. Take this key, you might need it.";
            }
            else if (key)
            {
                text = "Try to open a locked wall with your key.";
            }
            else
            {
                text = "Find Amogus Green, he can help you further.";
            }
            return text;
        }

        public string AmogusGreen(bool firstTimeInteractingWithGreen, bool key)
        {
            string text;
            if (firstTimeInteractingWithGreen)
            {
                text = "Now that you get the basics, it's time for the real adventure, take this key and escape this library.";
            }
            else if (key)
            {
                text = "Go to the right and open that door.";
            }
            else
            {
                text = "It's time to leave";
            }
            return text;
        }

        public string AmogusPink(int InteractionsWithPink, int InterActionsWithYellow)
        {
            string text;
            if (InteractionsWithPink == 0)
            {
                text = "Hey Red, Watch out for Yellow Amogus, he's kinda sus. He might kill you if you come too close to him. Take this, now you can run faster if you click SPACEBAR. Btw can you get that knife for me.";
            }
            else if (InterActionsWithYellow > 0)
            {
                text = "I swear i'm not following yellow. Yellow Vented. Wanna start a meet and vote him out?";
            }
            else
            {
                text = "Try to run past Yellow and bring me the knife so i can defend myself";
            }
            return text;
        }
        public string AmogusPink()
        {
            string text = "OK, but if you die don't blame ME";
            return text;
        }
        public string AmogusPink(bool knife)
        {
            string text ="";
            if (knife)
            {
                text = "Thx for the knife noob";
                return text;
            }
            else if (!knife)
            {
                text = "You killed Yellow! Murderer!";
                return text;
            }
            return text;
        }

        public string AmogusYellow(int InterActionsWithYellow, int InteractionsWithPink)
        {
            string text;
            if (InterActionsWithYellow == 0)
            {
                text = "Hey, watch out for pink. he's been following me for a while. He's pretty sus";
            }
            else if (InteractionsWithPink > 0)
            {
                text = "Wait, he said bring me the knife? I'm starting a meet, lets vote him out";
            }
            else
            {
                text = "Pink is not even doing tasks, he's so fricking sus";
            }
            return text;
        }
        public string AmogusYellow()
        {
            string text = "Ok bro, I understand, we should play safe";
            return text;
        }
        public string AmogusYellow(bool knife)
        {
            string text = "WHY DO YOU HAVE A KNIFE!";
            return text;
        }
    }
}
