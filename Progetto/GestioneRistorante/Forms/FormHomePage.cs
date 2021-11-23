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
    public partial class FormHomePage : Form
    {
        // Costrutore della classe
        public FormHomePage()
        {
            InitializeComponent();
            // Istanzio il database 
            Database database = Database.GetInstance();
            // faccio partire la connesione al database
            database.Connect(Properties.Settings.Default.StringaConnessione);
             
        }


        // Pulsante per la prenotazione dell'asporto
        private void BtnOrdinaAsporto_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu((int)Prenotazione.EnumTipologia.ASPORTO);
            menu.ShowDialog();

        }


        // Pulsante per la prenotazione a domicilio
        private void BtnDomicilio_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu((int)Prenotazione.EnumTipologia.DOMICILIO);
            menu.ShowDialog();

        }


        // Pulsante per la prenotazione del tavolo
        private void BtnPrenotaTavolo_Click(object sender, EventArgs e)
        {
            FormPrenotaTavolo prenotaTavolo = new FormPrenotaTavolo();
            prenotaTavolo.ShowDialog();
        }


        // Pulsante per visualizzare la lista delle prenotazioni
        private void BtnListaPrenotazioni_Click(object sender, EventArgs e)
        {
            FormListaPrenotazioni listaPrenotazioni = new FormListaPrenotazioni();
            listaPrenotazioni.Show();
        }


        // Pulsante per visualizzare la panoramica dei tavoli
        private void BtnListaTavoli_Click(object sender, EventArgs e)
        {
            FormPanoramicaTavoli panoramicaTavoli = new FormPanoramicaTavoli();
            panoramicaTavoli.ShowDialog();
        }
    }
}
