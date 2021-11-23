using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneRistorante
{
    interface IAccessoDati
    {
        // Connette il database
        bool Connect(string connectionString);
        
        // Chiude il collegamento
        bool Close();
    }
}
