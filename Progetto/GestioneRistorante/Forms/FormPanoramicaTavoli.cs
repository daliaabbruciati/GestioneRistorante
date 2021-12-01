using System;
using System.Collections;
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
    public partial class FormPanoramicaTavoli : Form, IObserver
    {
        // Attributi della classe
        List<Tavolo> tavoli = new List<Tavolo>();
        List<Prenotazione> prenotazioni = new List<Prenotazione>();
        private static Timer timer;
        Dictionary<int, Control> labels;
        Dictionary<int, Control> buttons;

        // Costruttore della classe
        public FormPanoramicaTavoli()
        {
            // Dictionary prende il numero del tavolo e il controllo ovvero
            // l'eticehtta o il bottone
            labels = new Dictionary<int, Control>(100);
            buttons = new Dictionary<int, Control>(100);
            InitializeComponent();

            foreach(Control ctr in this.Controls)
            {
                if (ctr.Name.StartsWith("lblAttesa"))
                {
                    labels.Add(int.Parse(ctr.Name.Substring(9)), (Label)ctr);
                }else if (ctr.Name.StartsWith("btnTav"))
                {
                    buttons.Add(int.Parse(ctr.Name.Substring(6)), (Button)ctr);
                }
            }

            RefreshTavoli();
            timer = new Timer();
            // imposto l'intervallo di tempo di 1 minuto
            timer.Interval = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
            // ogni minuto viene eseguito il metodo Timer_Tick
            timer.Tick += Timer_Tick;
            // fa partire il timer
            timer.Start();
            // fa subito un tick
            Timer_Tick(null, null);
            
        }

        // Ogni minuto manda una notifica al tavolo
        private void Timer_Tick(object sender, EventArgs e)
        {
            RefreshPrenotazioni();
            foreach (Tavolo t in tavoli)
            {
                t.Notify();
            }
        }


        // Quando clicco su un tavolo
        private void BtnTav_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name;
            string idTavolo = name.Substring(6);
            List<Tavolo> t = Database.GetInstance().GetTavoli();
            // prendo l'idprenotazione del tavolo su cui ho cliccato
            string idPrenotazione = t.Where(x => x.IDTavolo.ToString() == idTavolo).FirstOrDefault().IDPrenotazione;
           
            // cliccando su un tavolo occupato, mostra le informazione della prenotazione relative a quel tavolo
            if(!string.IsNullOrEmpty(idPrenotazione)){
                FormInfoPrenotazione infoPrenotazione = new FormInfoPrenotazione(idPrenotazione);
                infoPrenotazione.ShowDialog();
                RefreshTavoli();
                Timer_Tick(null, null);
            }
            else
            {
                MessageBox.Show("Tavolo libero");
            }
        }


        // Metodo per aggiornare l'attesa di un tavolo
        public void UpdateAttesa(Tavolo t)
        {
            // prendo l'id del tavolo aggiornato dal database per prendere l'id della sua prenotazione
            string idPrenotazione = tavoli.Where(x => x.IDTavolo == t.IDTavolo).FirstOrDefault().IDPrenotazione;
            // se il tavolo e' occupato
            if (!string.IsNullOrEmpty(idPrenotazione))
            {
                // prendo la prenotazione completa
                Prenotazione p = prenotazioni.Where(x => x.IDPrenotazione == idPrenotazione).FirstOrDefault();
                // aggiorno il tempo di attesa
                int attesa = (DateTime.Now - ((AlTavolo)p).OraUltimoOrdine).Minutes;
                
                // in base al tempo di attesa i tavoli cambiano colore
                if (attesa >= 0)
                {
                    ((Label)labels[t.IDTavolo]).Text = "Attesa: " + attesa;

                    if (attesa <= 2)
                    {
                        ((Button)buttons[t.IDTavolo]).BackColor = Color.LightGreen;
                    }
                    else if (attesa <= 4)
                    {
                        ((Button)buttons[t.IDTavolo]).BackColor = Color.Orange;
                    }
                    else
                    {
                        ((Button)buttons[t.IDTavolo]).BackColor = Color.Red;
                    }
                }
                else 
                {
                    /* caso in cui il cliente prenota per un orario diverso da quello corrente,
                       viene cambiata l'etichetta e il colore */
                    ((Label)labels[t.IDTavolo]).Text = "Arrivo tra: " + attesa;
                    ((Button)buttons[t.IDTavolo]).BackColor = Color.Blue;
                }
                /* quando lo stato del tavolo e' settato su 'DA_PAGARE', viene cambiata
                   l'etichetta e il colore */
                if (p.Stato == (int)Prenotazione.EnumStato.DA_PAGARE)
                {
                    ((Label)labels[t.IDTavolo]).Text = "Da pagare";
                    ((Button)buttons[t.IDTavolo]).BackColor = Color.DarkRed;
                }
            }
            else
            {
                ((Button)buttons[t.IDTavolo]).BackColor = DefaultBackColor;
                ((Label)labels[t.IDTavolo]).Text = "Attesa: ";
            }
            Console.WriteLine("Aggiornamento attesa tavolo: " + t.IDTavolo);
        }


        // Aggiorna la lista delle prenotazioni
        private void RefreshPrenotazioni()
        {
            prenotazioni = Database.GetInstance().GetPrenotazioni();
        }


        // Aggiorna la lista dei tavoli
        private void RefreshTavoli()
        {
            tavoli = Database.GetInstance().GetTavoli();
            // la finstra si iscrive a tutti i tavoli
            foreach (Tavolo t in tavoli)
            {
                t.Register(this);
            }
        }


        // Si disiscrive quando si chiude la finestra o quando si libera un tavolo
        private void PanoramicaTavoli_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Tavolo t in tavoli)
            {
                t.Unregister(this);
            }
        }


        // Pulsante per tornare alla schermata precedente
        private void BtnIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
