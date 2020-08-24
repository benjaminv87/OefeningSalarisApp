using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningSalarisApp
{
    public class Werknemer
    {

        public string Naam;
        public string LandVanHerkomst;
        public Salaris Salaris = new Salaris();

        public Werknemer(string naam, Salaris salaris,  string landVanHerkomst = "Belgïe" )
        {
            Naam = naam;
            LandVanHerkomst = landVanHerkomst;
            Salaris = salaris;
        }
        public Werknemer(string naam, string landVanHerkomst = "Belgïe")
        {
            Naam = naam;
            LandVanHerkomst = landVanHerkomst;
        }

        public override string ToString()
        {
            return Naam;
        }

    }
}
