using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningSalarisApp
{
    public class Programmeur : Werknemer
    {
        public List<string> ProgrammeerTalen= new List<string>() {"HTML","Java SE 11" };
        public Salaris salaris = new Salaris();
        public Programmeur(string naam, Salaris salaris, string landVanHerkomst): base(naam,salaris,landVanHerkomst)
        {
            salaris.NettoOnkosten = 50;
            salaris.BedrijfsWagenWaarde = 123;
        }
    }
}
