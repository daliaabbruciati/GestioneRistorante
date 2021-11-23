using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    public interface IObserver
    {
        void UpdateAttesa(Tavolo t);
    }
}
