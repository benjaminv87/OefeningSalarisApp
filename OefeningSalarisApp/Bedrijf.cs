using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningSalarisApp
{
    public class Bedrijf
    {
        public string Naam;
        public List<Werknemer> Werknemers = new List<Werknemer>();
        public string BtwNummer;

        public Bedrijf(string naam, string btwNummer)
        {
            Naam = naam;
            BtwNummer = btwNummer;
        }

        public void WerknemerToevoegen(Werknemer nieuweWerknemer)
        {
            Werknemers.Add(nieuweWerknemer);
        }
        public void VerwijderWerknemer(int index)
        {
            Werknemers.RemoveAt(index);
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
