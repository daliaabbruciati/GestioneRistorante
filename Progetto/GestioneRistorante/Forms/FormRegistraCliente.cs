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
    public partial class FormRegistraCliente : Form
    {
        // Attributi della classe
        private Prenotazione p;
        private int idTavolo;
        private List<Ordine> selezione;
        public List<Ordine> Selezione { get => selezione; set => selezione = value; }

        // Costruttore della classe
        public FormRegistraCliente(int tipologia, int numPersone = 0, int idTavolo = 0)
        {
            InitializeComponent();
            // nuova prenotazione in base alla tipologia
            switch (tipologia)
            {
                case (int)Prenotazione.EnumTipologia.ASPORTO:
                    p = new Asporto();
                    lblIndirizzo.Visible = false;
                    txtIndirizzo.Visible = false;
                    break;
                case (int)Prenotazione.EnumTipologia.DOMICILIO:
                    p = new Domicilio();
                    break;
                case (int)Prenotazione.EnumTipologia.AL_TAVOLO:
                    p = new AlTavolo();
                    ((AlTavolo)p).NumeroPersone = numPersone;
                    this.idTavolo = idTavolo;
                    lblIndirizzo.Visible = false;
                    txtIndirizzo.Visible = false;
                    lblRecapito.Visible = false;
                    txtRecapito.Visible = false;
                    break;
                default:
                    p = new AlTavolo();
                    break;
            }
        }


        // Pulsante per confermare i dati per la registrazione del cliente
        private void BtnConferma_Click(object sender, EventArgs e)
        {
            // Controllo sui vari campi
            if(string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Errore campo Nome");
                return;
            }
            if ((string.IsNullOrEmpty(txtRecapito.Text) && txtRecapito.Visible) || (!long.TryParse(txtRecapito.Text, out long result) && txtRecapito.Visible))
            {
                MessageBox.Show("Errore campo Recapito");
                return;
            }
            if (string.IsNullOrEmpty(txtIndirizzo.Text) && txtIndirizzo.Visible)
            {
                MessageBox.Show("Errore campo Indirizzo");
                return;
            }

            p.NomePrenotazione = txtNome.Text;
            p.DataOra = new DateTime(data.Value.Year, data.Value.Month, data.Value.Day, ora.Value.Hour, ora.Value.Minute, ora.Value.Second);
            p.Stato = 0;
            p.Note = txtNote.Text;

            if (p.GetType() == typeof(Asporto))
            {
                ((Asporto)p).NumeroTelefono = txtRecapito.Text;

            }
            else if (p.GetType() == typeof(Domicilio))
            {
                ((Domicilio)p).NumeroTelefono = txtRecapito.Text;
                ((Domicilio)p).Indirizzo = txtIndirizzo.Text;

            }
            else if (p.GetType() == typeof(AlTavolo))
            {
                ((AlTavolo)p).OraUltimoOrdine = p.DataOra;
            }

            Database database = Database.GetInstance();
            database.SetPrenotazioni(p);
            if(this.idTavolo > 0)
            {
                database.UpdateTavolo(this.idTavolo, p.IDPrenotazione);
            }
            if(Selezione != null)
            {
                database.SetOrdine(Selezione, p.IDPrenotazione);
            }
            
            FormConcludiPrenotazione concludi = new FormConcludiPrenotazione();
            concludi.ShowDialog();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        // Pulsante per tornare alla schermaa precedente
        private void BtnIndietro_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
