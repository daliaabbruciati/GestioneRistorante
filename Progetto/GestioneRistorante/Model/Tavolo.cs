using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public class Tavolo : ISubject
    {
        // Attributi della classe
        private List<IObserver> observer = new List<IObserver>();
        private int idTavolo;
        private string idPrenotazione;
        private int numeroPosti;
        private int zona;


        public enum enumZona
        {
            Portico,
            Terrazza,
            SalaEsterna,
            SalaInterna,
            Aperitivo
        }


        // Costruttore della classe
        public Tavolo()
        {
        }


        // Costruttore della classe
        public Tavolo(int idTavolo, string idPrenotazione, int numeroPosti, int zona)
        {
            this.IDTavolo = idTavolo;
            this.IDPrenotazione = idPrenotazione;
            this.NumeroPosti = numeroPosti;
            this.Zona = zona;
        }


        // Incapsulamento
        public int IDTavolo { get => idTavolo; set => idTavolo = value; }
        public string IDPrenotazione { get => idPrenotazione; set => idPrenotazione = value; }
        public int NumeroPosti { get => numeroPosti; set => numeroPosti = value; }
        public int Zona { get => zona; set => zona = value; }


        // Registra un tavolo all'observer
        public void Register(IObserver observer) 
        {
            this.observer.Add(observer);
        }


        // Disiscrive un tavolo dall'observer
        public void Unregister(IObserver observer)
        {
            this.observer.Remove(observer);
        }


        // Controlla lo stato del tavolo
        public void Notify()
        {
            this.observer.ForEach(o => o.UpdateAttesa(this)); 
        }
    }
}
