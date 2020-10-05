﻿using System;
using System.Collections.Generic;

namespace haromszogek

{
    internal class Haromszog
    {
        private double aoldal;
        private double boldal;
        private double coldal;

        public Haromszog(double aoldal, double boldal, double coldal)
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.coldal = coldal;
            szerk();
        }

        public double terulet { get; private set; }

        public double kerulet { get; private set; }


        public bool szerkesztheto { get; private set; }


        private void szerk()
        {
            if (aoldal + boldal > coldal &&
                boldal + coldal > aoldal &&
                aoldal + coldal > boldal
                )

            {
                szerkesztheto = true;
                terulet = teruletszamitas();
                kerulet = keruletszamitas();
            }
            else
            {
                szerkesztheto = false;
                terulet = 0;
                kerulet = 0;
            }


        }

        private double teruletszamitas()
        {
            double s = 0;
            s += aoldal + boldal + coldal / 2;
            return Math.Sqrt(s * (s - aoldal) * (s - boldal) * (s - coldal));




        }


        private double keruletszamitas()
        {
            return aoldal + boldal + coldal;


        }


        public List<string> adatokSzoveg()
        {
            List<string> adatok = new List<string>();

            adatok.Add($"a: {aoldal} - b: {boldal} - c: {coldal}");
            if (szerkesztheto)
            {
                adatok.Add($"Kerület: {kerulet:N2} - Terület: {terulet:N2}");
            }
            else
            {
                adatok.Add("Nem szerkeszthető");
            }
            return adatok;
        }



    }
}