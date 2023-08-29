using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11_2
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double Età { get; set; }
         
        public Persona() { }
        public Persona(string nome, string cognome, double età)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
        }

      public string GetNome() {
        return "Il mio nome è "+ Nome;
        }
        public string GetCognome()
        {
            return "Il mio cognome è " + Cognome;
        }
        public double GetEtà()
        {
            return  Età;
        }
        public string GetDettagli()
        {
            return "Mi chiamo " + Nome + " " + Cognome + " e ho " + Età +" anni";
        }
    }
}
