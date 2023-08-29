using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona
            Persona persona = new Persona("Erica","Diana",19) ;

            Console.WriteLine("Inserisci nome");
            string nome= Console.ReadLine();

            Console.WriteLine("Inserisci cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci età");
            double età = Convert.ToDouble(Console.ReadLine());

            Persona persona1 = new Persona(nome, cognome, età);

            //Prodotto

            Console.WriteLine("Inserisci nome prodotto");
            string nomeProdotto = Console.ReadLine();

            Console.WriteLine("Inserisci prezzo");
            double prezzo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inserisci quantità");
            double quantità = Convert.ToDouble(Console.ReadLine());

            Prodotto prodotto = new Prodotto(nomeProdotto, prezzo, quantità);

            //Televisione
            Televisione televisione= new Televisione();
            Console.WriteLine("Premi 0 per accendere la tv 1 per spegnerla");
            string stato = Console.ReadLine();

            Console.WriteLine("Inserisci numero del volume");
            double volume = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Inserisci canale");
            double canale = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("muto/smuta");
            string statoVolume = Console.ReadLine();

            Televisione televisione1  = new Televisione(stato, volume, canale,statoVolume);


            //Persona
            Console.WriteLine(persona1.GetNome());
            Console.WriteLine(persona1.GetCognome());
            Console.WriteLine("Ho " + persona1.GetEtà() + " anni");
            Console.WriteLine(persona1.GetDettagli());
            Console.WriteLine(" ");

            //Prodotto

            Console.WriteLine(prodotto.GetNomeProdotto());
            Console.WriteLine("Prezzo: " + prodotto.GetPrezzo());
            Console.WriteLine("Quantità: " + prodotto.GetQuantità());
            Console.WriteLine(prodotto.GetDettagli());
            Console.WriteLine(prodotto.CalcolaTotale());
            Console.WriteLine(" ");

            //Televisione
            Console.WriteLine("on/off: "+televisione1.PulsanteAccensione());
            Console.WriteLine("Canale successivo: " + televisione1.CanaleSuccessivo());
            Console.WriteLine("Canale precedente: " + televisione1.CanalePrecedente());
            Console.WriteLine("Aumenta volume: " + televisione1.AumentaVolume());
            Console.WriteLine("Abbassa volume: " + televisione1.AbbassaVolume());
            Console.WriteLine("Seleziona canale: " + televisione1.ImpostaCanale());
            Console.WriteLine("Stato tv: " + televisione1.PrintStatoTv());
            Console.WriteLine("StatoVolume: " + televisione1.PulsanteSilenzioso());
            Console.ReadLine();

        }
    }
}
