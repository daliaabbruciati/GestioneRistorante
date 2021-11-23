using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneRistorante
{
    public partial class FormListaPrenotazioni : Form
    {
        // Attributi della classe
        List<Prenotazione> prenotazioni = new List<Prenotazione>();
        
        // Costruttore della classe
        public FormListaPrenotazioni()
        {
            InitializeComponent();

            // creo il pulsante 'Elimina'
            MenuItem[] menuItems = new MenuItem[] { new MenuItem("Elimina", OnDelete) };
            ContextMenu contextMenu = new ContextMenu(menuItems);
            lViewPrenotazioni.ContextMenu = contextMenu;
            RefreshPrenotazioni();
        }


        // Metodo per eliminare una prenotazione
        private void OnDelete(object sender, EventArgs e)
        {
            // se clicco con il tasto destro sull'evento 'e'
            if (lViewPrenotazioni.SelectedItems != null)
            {
                string id = lViewPrenotazioni.SelectedItems[0].Text;
                Database.GetInstance().DeletePrenotazione(id);
                RefreshPrenotazioni();
            }
        }


        // Pulsante che elimina tutte le prenotazioni presenti nella lista
        private void BtnEliminaTutto_Click(object sender, EventArgs e)
        {
            foreach (Prenotazione p in prenotazioni)
            {
                Database.GetInstance().DeletePrenotazione(p.IDPrenotazione);  
            }
            RefreshPrenotazioni();
        }


        // Carica la lista delle prenotazioni in base alla tipologia
        public void LoadPrenotazioni(List<Prenotazione> prenotazioni)
        {
            lViewPrenotazioni.Items.Clear();
            foreach (Prenotazione p in prenotazioni)
            {
                if (p.GetType() == typeof(Asporto))
                {
                    lViewPrenotazioni.Items.Add(new ListViewItem(new[] {p.IDPrenotazione, p.NomePrenotazione, null,
                    ((Asporto)p).NumeroTelefono, p.DataOra.ToString(), Enum.GetName(typeof(Prenotazione.EnumStato),p.Stato),null,null, "Asporto", p.Note.ToString()}));
                }
                else if (p.GetType() == typeof(Domicilio))
                {
                    lViewPrenotazioni.Items.Add(new ListViewItem(new[] {p.IDPrenotazione, p.NomePrenotazione, null,
                    ((Domicilio)p).NumeroTelefono, p.DataOra.ToString(), Enum.GetName(typeof(Prenotazione.EnumStato),p.Stato),null,((Domicilio)p).Indirizzo,"Domicilio",p.Note.ToString()}));

                }
                else if (p.GetType() == typeof(AlTavolo))
                {
                    lViewPrenotazioni.Items.Add(new ListViewItem(new[] {p.IDPrenotazione, p.NomePrenotazione, ((AlTavolo)p).NumeroPersone.ToString(),
                    null, p.DataOra.ToString(), Enum.GetName(typeof(Prenotazione.EnumStato),p.Stato),((AlTavolo)p).OraUltimoOrdine.ToString(),null,"Al tavolo",p.Note.ToString()}));

                }

            }

        }


        // Funzione filtro per le tipologie e gli stati delle prenotazioni
        private void FiltroCheck(object sender, EventArgs e)
        {
            List<Prenotazione> filtro = new List<Prenotazione>();
          
            foreach (Prenotazione p in prenotazioni)
            {
                bool stato = false, tipologia = false;

                if (ckAsporto.Checked)
                {
                    if (p.GetType() == typeof(Asporto))
                        tipologia = true;
                        
                }
                if (ckDomicilio.Checked)
                {
                    if (p.GetType() == typeof(Domicilio))
                        tipologia = true;
                }
                if (ckAlTavolo.Checked)
                {
                    if (p.GetType() == typeof(AlTavolo))
                        tipologia = true;
                }
                if (ckAttesa.Checked)
                {
                    if (p.Stato == (int)Prenotazione.EnumStato.IN_ATTESA)
                        stato = true;
                }
                if (ckDaPagare.Checked)
                {
                    if (p.Stato == (int)Prenotazione.EnumStato.DA_PAGARE)
                        stato = true;
                }
                if (ckTerminato.Checked)
                {
                    if (p.Stato == (int)Prenotazione.EnumStato.TERMINATO)
                        stato = true;
                }
                if(stato && tipologia)
                {
                    filtro.Add(p);
                }
            }
            // Load prenotazioni ricarica la lista e se trova doppioni li rimuove con Distinct.
            LoadPrenotazioni(filtro.Distinct().ToList());
        }


        // Aggiorna la lista delle prenotazioni
        public void RefreshPrenotazioni()
        {
            // prendo l'istanza del database
            Database database = Database.GetInstance();
            prenotazioni = database.GetPrenotazioni();
            LoadPrenotazioni(prenotazioni);
        }


        // Facendo doppio click su una prenotazione mi apre le info relative ad essa
        private void LViewPrenotazioni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lViewPrenotazioni.SelectedItems != null)
            {
                string id = lViewPrenotazioni.SelectedItems[0].Text;
               
                FormInfoPrenotazione infoPrenotazione = new FormInfoPrenotazione(id);
                infoPrenotazione.ShowDialog();
                RefreshPrenotazioni();
            }
        }


        // Pulsante per tornare nella form precedente
        private void BtnIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
