using System;
using System.Collections.Generic;
using System.Text;

namespace AutoDagWaarde
{
    class Auto
    {
        // Fields
        private int kilometerstand = 1;
        private BrandstofSoort brandstof;
        private string kenteken;

        // Properties
        public int Kilometerstand { get { return kilometerstand; } }


        // Constructors
        public Auto(string kenteken, BrandstofSoort brandstof)
        {
            this.kenteken = kenteken;
            this.brandstof = brandstof;
        }

        public Auto(string kenteken, BrandstofSoort brandstof, int kilometers)
        {
            this.kenteken = kenteken;
            this.brandstof = brandstof;
            this.kilometerstand = kilometers;
        }

        // Methods
        public void RijdKilometers(int afstand)
        {
            if (afstand > 0)
            {
                kilometerstand = kilometerstand + afstand;
            }
            else { }
        }

        public int BerekenDagwaarde()
        {
            int dagwaarde = 500000 / kilometerstand * (int)brandstof;
            return dagwaarde;
        }

        public override string ToString()
        {
            return (kenteken + " " + brandstof + " " + kilometerstand + " kilometers gereden, huidige dagwaarde " + BerekenDagwaarde()).ToString();
        }
    }
}
