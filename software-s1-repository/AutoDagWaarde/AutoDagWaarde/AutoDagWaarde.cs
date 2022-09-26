using System;
using System.Collections.Generic;

namespace AutoDagWaarde
{
    public enum BrandstofSoort
    {
        benzine = 100,
        diesel = 150,
        lpg = 90,
        elektrische = 130
    }

    class AutoDagWaarde
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Auto> list = new List<Auto>();

            Auto auto1 = new Auto("85-HS-ZR", BrandstofSoort.diesel);
            list.Add(auto1);

            Auto auto2 = new Auto("RK-320-K", BrandstofSoort.diesel);
            list.Add(auto2);

            Auto auto3 = new Auto("GX-714-S", BrandstofSoort.diesel);
            list.Add(auto3);

            Auto auto4 = new Auto("54-VB-ND", BrandstofSoort.diesel);
            list.Add(auto4);

            for (int i = 0; i < list.Count; i++)
            {
                // auto telkens opnieuw laten rijden totdat die op het minst 100000 kilometer heeft gereden
                while(list[i].Kilometerstand < 100000)
                {
                    list[i].RijdKilometers(rnd.Next(1000, 20001));
                    Console.WriteLine(list[i].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}

/*
Requirements

DONE
- Definieer een enum BrandstofSoort met bovenstaande waarden.
- Een class Auto met properties kilometerstand en Brandstof.
- Auto heeft een public property KmStand met beginwaarde 1 (private setter). (Enig idee waarom we niet bij 0 beginnen?). dan deel je door nul >:)
- Auto heeft een read only property Kenteken (een String) die als parameter aan de constructor meegegeven wordt.
- Auto heeft een method RijdKilometers met als parameter een geheel getal.
- RijdKilometers controleert of de parameter een positief getal is. Zoja, dan wordt de KmStand met dat bedrag verhoogd.
- Auto heeft een property Brandstof van type BrandstofSoort. Deze wordt als parameter aan de constructor meegegeven.
- Class Auto heeft verder een read-only property Dagwaarde. Deze voert de berekening uit en geeft het goede antwoord terug.
- override de ToString() method van Auto zodat er iets komt te staan als AB-12-CD elektrische auto 12345 km op de teller heeft een dagwaarde van 12345 euro.
- extra1
- extra2

TO DO
 */