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
    public partial class FormPrenotaTavolo : Form
    {
        // Attributi della classe
        List<Tavolo> tavoli = new List<Tavolo>();
        private List<Ordine> selezione;
        public List<Ordine> Selezione { get => selezione; set => selezione = value; }

        // Costruttore della classe
        public FormPrenotaTavolo()
        {
            InitializeComponent();
            tavoli = Database.GetInstance().GetTavoli();

            // conteggio del numero dei tavoli ancora disponibili sia per zona sia in totale
            lblTavoliPortico.Text += tavoli.Where(x => x.Zona == (int)Tavolo.enumZona.Portico && string.IsNullOrEmpty(x.IDPrenotazione)).Count();
            lblTavoliTerrazza.Text += tavoli.Where(x => x.Zona == (int)Tavolo.enumZona.Terrazza && string.IsNullOrEmpty(x.IDPrenotazione)).Count();
            lblTavoliSalaEsterna.Text += tavoli.Where(x => x.Zona == (int)Tavolo.enumZona.SalaEsterna && string.IsNullOrEmpty(x.IDPrenotazione)).Count();
            lblTavoliSalaInterna.Text += tavoli.Where(x => x.Zona == (int)Tavolo.enumZona.SalaInterna && string.IsNullOrEmpty(x.IDPrenotazione)).Count();
            lblTavoliAperitivo.Text += tavoli.Where(x => x.Zona == (int)Tavolo.enumZona.Aperitivo && string.IsNullOrEmpty(x.IDPrenotazione)).Count();
            lblTavoliTotali.Text += tavoli.Where(x => string.IsNullOrEmpty(x.IDPrenotazione)).Count();
        }

        // Pulsante per confermare la prenotazione
        private void BtnConferma_Click(object sender, EventArgs e)
        {
            // cerco il tavolo migliore per numero di persone all'interno della zona selezionata
            int idTavolo = tavoli.Where(x => x.Zona == cmbZona.SelectedIndex).OrderBy(x => x.NumeroPosti).Where(x => x.NumeroPosti >= numPersone.Value).Select(x => x.IDTavolo).FirstOrDefault();
            if(idTavolo == 0)
            {
                MessageBox.Show("Non esiste tavolo disponibile per "+numPersone.Value+" persone nella zona selezionata");
                return;
            }
            // si apre la form per registrare i dati del cliente
            FormRegistraCliente infoCliente = new FormRegistraCliente((int)Prenotazione.EnumTipologia.AL_TAVOLO,(int)numPersone.Value,idTavolo);
            infoCliente.Selezione = this.selezione;
            if (infoCliente.ShowDialog() != DialogResult.Cancel)
            {
                this.Close();
            } 

        }


        // Pulsate che rimanda alla schermata del menu
        private void BtnScegliMenu_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu((int)Prenotazione.EnumTipologia.AL_TAVOLO);
            menu.ShowDialog();
            this.selezione = menu.CibiSelezionati;
            BtnConferma_Click(null, null);
        }


        // Pulsante per tornare alla schermata precedente
        private void BtnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
