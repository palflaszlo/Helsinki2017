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

        public Versenyzo(string nev, string orszag, double technika, double komponens, int levonas)
        {
            this.nev = nev;
            this.orszag = orszag;
            this.technika = technika;
            this.komponens = komponens;
            this.levonas = levonas;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public double Technika { get => technika; set => technika = value; }
        public double Komponens { get => komponens; set => komponens = value; }
        public int Levonas { get => levonas; set => levonas = value; }
    }
}
