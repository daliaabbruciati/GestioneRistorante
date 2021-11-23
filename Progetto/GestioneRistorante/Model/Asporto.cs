using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public class Asporto : Prenotazione
    {
        // Attributi della classe
        protected string numeroTelefono;

        // Incapsulamento
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
    }
}
