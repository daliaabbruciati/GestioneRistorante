using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public abstract class Prenotazione
    {
        // Attributi della classe
        protected string idPrenotazione;
        protected string nomePrenotazione;
        protected DateTime dataOra;
        protected int stato;
        protected string note;
        
        public enum EnumTipologia
        {
             ASPORTO = 0,
             DOMICILIO = 1,
             AL_TAVOLO = 2
        }


        public enum EnumStato
        {
            IN_ATTESA = 0,
            DA_PAGARE = 1,
            TERMINATO = 2
        }


        // Incapsulamento
        public string IDPrenotazione { get => idPrenotazione; set => idPrenotazione = value; }
        public string NomePrenotazione { get => nomePrenotazione; set => nomePrenotazione = value; }
        public DateTime DataOra { get => dataOra; set => dataOra = value; }
        public int Stato { get => stato; set => stato = value; }
        public string Note { get => note; set => note = value; }
    }

   
}
