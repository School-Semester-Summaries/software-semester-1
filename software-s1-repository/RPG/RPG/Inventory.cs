using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Inventory
    {
        // Fields
        private bool key = false;
        private bool run = false;
        private bool knife = false;

        // Properties
        public bool Key { get { return key; } }
        public bool Run { get { return run; } }
        public bool Knife { get { return knife; } }

        // Methods
        public void KeyObtained()
        {
            key = true;
        }
        public void KeyUsed()
        {
            key = false;
        }

        public void RunningObtained()
        {
            run = true;
        }

        public void KnifeObtained()
        {
            knife = true;
        }
        public void KnifeUsed()
        {
            knife = false;
        }
    }
}
