using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11_2
{
    public class Prodotto
    {
        public string NomeProdotto { get; set; }
        public double Prezzo { get; set; }
        public double Quantità { get; set; }

        public Prodotto() { }
        public Prodotto(string nomeProdotto, double prezzo, double quantità)
        {
            NomeProdotto = nomeProdotto;
            Prezzo = prezzo;
            Quantità = quantità;
        }

        public string GetNomeProdotto()
        {
            return "Prodotto: "+ NomeProdotto;
        }
        public double GetPrezzo()
        {
            return  Prezzo;
        }
        public double GetQuantità()
        {
            return  Quantità;
        }
        public string GetDettagli()
        {
            return "Prodotto: " + NomeProdotto +" "+ "Prezzo: " + Prezzo + " Quantità: " + Quantità + " anni";
        }

        public double CalcolaTotale()
        {
            return Prezzo * Quantità;
        }
    }
}
