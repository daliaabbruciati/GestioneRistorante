using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public class Ordine : Cibo
    {
        // Attributi della classe
        private int quantita;


        // Costruttore della classe
        public Ordine()
        {
        }


        // Costruttore della classe
        public Ordine(int quantita, int id)
        {
            this.Quantita = quantita;
            base.IdCibo = id;
        }


        // Incapsulamento
        public int Quantita { get => quantita; set => quantita = value; }
    }
}
