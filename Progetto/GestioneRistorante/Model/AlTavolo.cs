using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public class AlTavolo : Prenotazione
    {
        // Attributi della classe
        private int numeroPersone;
        private DateTime oraUltimoOrdine;

        // Incapsulamento
        public int NumeroPersone { get => numeroPersone; set => numeroPersone = value; }
        public DateTime OraUltimoOrdine { get => oraUltimoOrdine; set => oraUltimoOrdine = value; }
    }

}
