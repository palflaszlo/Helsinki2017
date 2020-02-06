﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki2017
{
    class Program
    {
        static List<Versenyzo> versenyzok;

        private static void Beolvasas()
        {
            versenyzok = new List<Versenyzo>();
            using(var sr = new StreamReader("rovidprogram.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    string nev = sor[0];
                    string orszag = sor[1];
                    double technika = Convert.ToDouble(sor[2].Replace('.', ','));
                    double komponens = Convert.ToDouble(sor[3].Replace('.', ','));
                    int levonas = Convert.ToInt32(sor[4]);
                    var versenyzo = new Versenyzo(nev, orszag, technika, komponens, levonas);
                    versenyzok.Add(versenyzo);
                }
            }
            using (var sr = new StreamReader("donto.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    string nev = sor[0];
                    string orszag = sor[1];
                    double technika = Convert.ToDouble(sor[2].Replace('.', ','));
                    double komponens = Convert.ToDouble(sor[3].Replace('.', ','));
                    int levonas = Convert.ToInt32(sor[4]);
                    foreach (var versenyzo in versenyzok)
                    {
                        if(versenyzo.Nev == nev)
                        {
                            versenyzo.Technika2 = technika;
                            versenyzo.Komponens2 = komponens;
                            versenyzo.Levonas2 = levonas;
                            break;
                        }
                    }
                }
            }
        }

        private static void Második()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("\tA rövid programban {0} induló volt", versenyzok.Count);
        }

        private static void Harmadik()
        {
            Console.WriteLine("3. feladat");
            bool bejutott = false;
            foreach (var versenyzo in versenyzok)
            {
                if (versenyzo.Orszag == "HUN" && versenyzo.Technika2 > 0)
                {
                    bejutott = true;
                }
            }
            Console.WriteLine("\tA magyar versenyzo {0} a kürbe", bejutott ? "bejutott" : "nem jutott be" );
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Második();
            Harmadik();
            Console.ReadLine();
        }
    }
}
