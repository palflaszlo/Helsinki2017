using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki2017
{
    class Versenyzo
    {
        //rövidprogramban szerzett pontok
        string nev;
        string orszag;
        double technika;
        double komponens;
        int levonas;
        //döntőben szerzett pontok
        double technika2;
        double komponens2;
        int levonas2;

        public double ÖsszPontszám
        {
            get
            {
                return technika + komponens - levonas + technika2 + komponens2 - levonas2;
            }
        }

        public double OsszPontszam()
        {
            return technika + komponens - levonas + technika2 + komponens2 - levonas2;
        }

        public Versenyzo(string nev, string orszag, double technika, double komponens, int levonas)
        {
            this.nev = nev;
            this.orszag = orszag;
            this.technika = technika;
            this.komponens = komponens;
            this.levonas = levonas;
            this.technika2 = 0;
            this.komponens2 = 0;
            this.levonas2 = 0;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public double Technika { get => technika; set => technika = value; }
        public double Komponens { get => komponens; set => komponens = value; }
        public int Levonas { get => levonas; set => levonas = value; }
        public double Technika2 { get => technika2; set => technika2 = value; }
        public double Komponens2 { get => komponens2; set => komponens2 = value; }
        public int Levonas2 { get => levonas2; set => levonas2 = value; }
    }
}
