using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w11_2
{
    public class Televisione
    {
        private string _stato;
        public string Stato
        {
            get { return _stato; }
            set { _stato = value; }
        }
        public double Volume { get; set; }
        public double Canale { get; set; }
        public string StatoVolume { get; set; }
        public string volumepiù { get; set; }
        public string volumemeno { get; set; }

        public Televisione() { }
        //  public Televisione(string stato, string volume, string canale, string statoVolume) : this(stato, volume, canale, statoVolume) { }
        public Televisione(string stato, double volume, double canale, string statoVolume)
        {
            Stato = stato;
            Volume = volume;
            Canale = canale;
            StatoVolume = statoVolume;
        }

    

        public string PulsanteAccensione()
        {
            if (_stato == "0")
            {
                return _stato = "Accesa";
            }
            else if (_stato == "1")
            {
                return _stato = "Spenta";
            }
            else
            {
                return _stato = "spenta";
            }

        }
        public double CanaleSuccessivo()
        {
            if (Canale == 10)
            {
                return Canale=0;
            }
            else { return Canale + 1; }

        }
        public double CanalePrecedente()
        {
            if(Canale == 0)
            {
                return Canale + 10;
            }
            else { return Canale -1;}

        }

        public double AumentaVolume()
        {
            if (Volume == 99)
            {
                return Volume ;
            }
            else { return Volume +1; }

        }

        public double AbbassaVolume()
        {
            if (Volume == 0)
            {
                return Volume ;
            }
            else { return Volume - 1; }

        }
        public double ImpostaCanale()
        {
            return Canale;
        }

        public string printStatoTv()
        {
           return"On/Off "+ Stato + "Volume " + Volume+ "Canale  " + Canale + "StatoVolume " + StatoVolume;

        }

        public string PulsanteSilenzioso()
        {
            if (StatoVolume == "muto")
            {
                return StatoVolume = "Muto";
            }
            else if (StatoVolume == "smuta")
            {
                return "volume presente";
            }
            else
            {
                return "Volume presente";
            }


        }
    }
}