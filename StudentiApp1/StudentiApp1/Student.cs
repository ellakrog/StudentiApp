using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentiApp1
{
    public class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public int Generacija { get; set; }
        public string Smer { get; set; }
        public int Semestar { get; set; }
        public string UlicaStanovanja { get; set; }
        public int BrojStanovanja { get; set; }
        public string MestoStanovanja { get; set; }
        public double Telefon { get; set; }
        public int StudentId { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + DatumRodjenja + " " + Generacija + " " + Smer + " " + Semestar + " " +
                UlicaStanovanja + " " + BrojStanovanja + " " + MestoStanovanja + " " + Telefon;  ; 
        }
        public string stampaj()
        {
             return $"{Ime}, {Prezime}, {DatumRodjenja}, {Generacija}, {Smer}, {Semestar}, {UlicaStanovanja}, {BrojStanovanja}, {MestoStanovanja}, {Telefon} ";
        }
    }
}
