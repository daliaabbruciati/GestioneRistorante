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
    public partial class FormInfoPrenotazione : Form
    {
        // Attributi della classe
        Prenotazione p;
        Tavolo t;
        List<Ordine> cibiSelezionati;
        string id;
       
        // Costruttore della classe
        public FormInfoPrenotazione(string id)
        {
            InitializeComponent();
            this.id = id;
            
            // per eliminare un cibo
            MenuItem[] menuItems = new MenuItem[] { new MenuItem("Elimina", OnDelete) };
            ContextMenu contextMenu = new ContextMenu(menuItems);
            listViewOrdine.ContextMenu = contextMenu;

            List<Prenotazione> prenotazioni = Database.GetInstance().GetPrenotazioni();
            p = prenotazioni.Where(x => x.IDPrenotazione == id).FirstOrDefault();
            t = Database.GetInstance().GetTavoli().Where(x => x.IDPrenotazione == id).FirstOrDefault();
            // metto i cibi selezionati nell'ordine della prenotazione
            cibiSelezionati = Database.GetInstance().GetOrdine(id);
            // aggiorno la lista dei cibi nell'ordine
            RefreshOrdini();
           
            // campi in comune con tutte le tipologie
            txtNomeModifica.Text = p.NomePrenotazione;
            dataModifica.Value = p.DataOra;
            oraModifica.Value = p.DataOra;
            cmbStato.SelectedIndex = p.Stato;
            txtNoteModifica.Text = p.Note;
            
            // in base alla tipologia di prenotazione cerranno visualizzati o meno i vari campi
            if (p.GetType() == typeof(Asporto))
            {
                // campi visibili
                txtRecapitoModifica.Text = ((Asporto)p).NumeroTelefono;
                cmbTipologia.SelectedIndex = (int)Prenotazione.EnumTipologia.ASPORTO;
                // campi nascosti
                lblIndirizzo.Visible = false;
                txtIndirizzoModifica.Visible = false;
                lblNumPersone.Visible = false;
                numPersone.Visible = false;
                lblNumTavolo.Visible = false;
                txtNumTavolo.Visible = false;
                lblZona.Visible = false;
                cmbZona.Visible = false;
                lblNumPosti.Visible = false;
                txtNumPosti.Visible = false;
                lblTempoAttesa.Visible = false;
                txtTempoAttesa.Visible = false;
                btnAzzeraAttesa.Visible = false;
            }
            else if (p.GetType() == typeof(Domicilio))
            {
                // campi visibili
                txtRecapitoModifica.Text = ((Domicilio)p).NumeroTelefono;
                txtIndirizzoModifica.Text = ((Domicilio)p).Indirizzo;
                cmbTipologia.SelectedIndex = (int)Prenotazione.EnumTipologia.DOMICILIO;
                // campi nascosti
                lblNumPersone.Visible = false;
                numPersone.Visible = false;
                lblNumTavolo.Visible = false;
                txtNumTavolo.Visible = false;
                lblZona.Visible = false;
                cmbZona.Visible = false;
                lblNumPosti.Visible = false;
                txtNumPosti.Visible = false;
                lblTempoAttesa.Visible = false;
                txtTempoAttesa.Visible = false;
                btnAzzeraAttesa.Visible = false;
            }
            else if (p.GetType() == typeof(AlTavolo))
            {
                // campi visibili
                numPersone.Value = ((AlTavolo)p).NumeroPersone;
                cmbTipologia.SelectedIndex = (int)Prenotazione.EnumTipologia.AL_TAVOLO;
                txtTempoAttesa.Text = (DateTime.Now - ((AlTavolo)p).OraUltimoOrdine).Minutes.ToString();
                if(t != null)
                {
                    txtNumTavolo.Text = t.IDTavolo.ToString();
                    cmbZona.SelectedIndex = t.Zona;
                    txtNumPosti.Text = t.NumeroPosti.ToString();
                }
                // campi nascosti
                if (p.Stato == (int)Prenotazione.EnumStato.DA_PAGARE)
                {
                    btnAggiungiCibo.Visible = false;
                }
                lblIndirizzo.Visible = false;
                txtIndirizzoModifica.Visible = false;
                lblRecapito.Visible = false;
                txtRecapitoModifica.Visible = false;
            }
        }


        // Aggiorna la lista delle prenotazioni
        public void RefreshOrdini()
        {
            // prendo la lista degli ordini dal database
            cibiSelezionati = Database.GetInstance().GetOrdine(id);
            // carico gli ordini
            LoadOrdini(cibiSelezionati);
            // per il calcolo del conto totale
            float totale = 0;
            foreach(Ordine p in cibiSelezionati)
            {
                totale += p.PrezzoCibo * p.Quantita;
            }
            lblEuro.Text = totale.ToString() + "€";
        }


        // Carica la lista delle prenotazioni in base alla tipologia
        public void LoadOrdini(List<Ordine> selezione)
        {
            listViewOrdine.Items.Clear();
            foreach (Ordine p in selezione)
            {
                listViewOrdine.Items.Add(new ListViewItem(new[] {p.IdCibo.ToString(), p.NomeCibo, p.Quantita.ToString(),
                    p.PrezzoCibo.ToString(),p.TipologiaCibo,p.Vegetariano.ToString()}));
            }
        }


        // Storno del cibo ordinato
        private void OnDelete(object sender, EventArgs e)
        {
            // se clicco con il tasto destro sul cibo selezionato
            if (listViewOrdine.SelectedItems != null)
            {
                string idCibo = listViewOrdine.SelectedItems[0].Text;
                Database.GetInstance().DeleteOrdine(id, idCibo);
                RefreshOrdini();
            }
        }


        // Pulsante che annulla la modifica
        private void BtnAnnullaModifica_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Pulsante che conferma la modifica dei dati 
        private void BtnConfermaModifica_Click(object sender, EventArgs e)
        {
            p.NomePrenotazione = txtNomeModifica.Text;
            p.NomePrenotazione = txtNomeModifica.Text;
            p.DataOra = dataModifica.Value;
            p.DataOra = oraModifica.Value;
            p.Stato = cmbStato.SelectedIndex;
            p.Note = txtNoteModifica.Text;

            if (cmbTipologia.SelectedIndex == (int)Prenotazione.EnumTipologia.ASPORTO)
            {
                ((Asporto)p).NumeroTelefono = txtRecapitoModifica.Text;
            }
            else if (cmbTipologia.SelectedIndex == (int)Prenotazione.EnumTipologia.DOMICILIO)
            {
                ((Domicilio)p).NumeroTelefono = txtRecapitoModifica.Text;
                ((Domicilio)p).Indirizzo = txtIndirizzoModifica.Text;
            }
            else if (cmbTipologia.SelectedIndex == (int)Prenotazione.EnumTipologia.AL_TAVOLO)
            {
                ((AlTavolo)p).NumeroPersone = (int)numPersone.Value;
            }
            
            if(p.Stato == (int)Prenotazione.EnumStato.TERMINATO)
            {
                BtnPaga_Click(null, null);
            }
            else
            {
                Database.GetInstance().UpdatePrenotazione(p);
            }
            this.Close();
        }


        // Pulsante per aggiungere altri cibi all'ordine/prenotazione
        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu((int)Prenotazione.EnumTipologia.AL_TAVOLO);
            menu.ShowDialog();
            Database.GetInstance().SetOrdine(menu.CibiSelezionati,p.IDPrenotazione);
            RefreshOrdini();
           
        }


        // Pulsante per azzerare i minuti di attesa dopo che un piatto viene portato
        private void BtnAzzeraAttesa_Click(object sender, EventArgs e)
        {
            ((AlTavolo)p).OraUltimoOrdine = DateTime.Now;
            txtTempoAttesa.Text = (DateTime.Now - ((AlTavolo)p).OraUltimoOrdine).Minutes.ToString();
            Database.GetInstance().UpdatePrenotazione(p);
        }

        
        // Pulsante per pagare il conto
        private void BtnPaga_Click(object sender, EventArgs e)
        {
            // viene aggiornato lo stato del tavolo in "TERMINATO" e liberato
            p.Stato = (int)Prenotazione.EnumStato.TERMINATO;
            Database.GetInstance().LiberaTavolo(id);
            Database.GetInstance().UpdatePrenotazione(p);
            this.Close();
        }
    }
}
