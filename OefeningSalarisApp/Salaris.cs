using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningSalarisApp
{
    public class Salaris
    {
        public enum TypeContract
        {
            maandcontract,
            weekcontract,
        }

        public double BrutoWedde;
        public double BedrijfsWagenWaarde;
        public double NettoOnkosten;
        public int BtwPercentage;
        public TypeContract Contract;

        public Salaris(TypeContract contract= TypeContract.maandcontract,double bedrijfsWagenWaarde=0,double nettoOnkosten = 0, double brutoWedde=2440.55,int btwPercentage= 21)
        {
            BrutoWedde = brutoWedde;
            Contract = contract;
            BtwPercentage = btwPercentage;
            BedrijfsWagenWaarde = bedrijfsWagenWaarde;
            NettoOnkosten = nettoOnkosten;
        }
        public virtual double BerekenNetto()
        {
            double netto = Math.Round(((BrutoWedde - (((BrutoWedde+BedrijfsWagenWaarde) / 100) * BtwPercentage))+NettoOnkosten),2);
            return netto;
        }

        public override string ToString()
        {
            return $"Bruto: {BrutoWedde}. Netto:{BerekenNetto()}";
        }
    }
}
