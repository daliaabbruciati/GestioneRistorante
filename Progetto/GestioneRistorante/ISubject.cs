using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public interface ISubject
    {
        // Si sottoscrive all'aggiornamento
        void Register(IObserver observer);
        // Si disiscrive dall'aggiornamento
        void Unregister(IObserver observer);
        // Notifica
        void Notify();
    }
}
