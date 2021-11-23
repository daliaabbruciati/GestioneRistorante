using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public class Domicilio : Asporto
    {
        // Attributi della classe
        private string indirizzo;


        // Incapsulamento
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
    }
}
