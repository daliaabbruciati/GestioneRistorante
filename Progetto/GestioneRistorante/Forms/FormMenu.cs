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
    
    public partial class FormMenu : Form
    {
        // Attributi interni della classe
        private List<Ordine> cibiSelezionati = new List<Ordine>();
        public List<Ordine> CibiSelezionati { get => cibiSelezionati; set => cibiSelezionati = value; }
        private int tipologia;


        // Costruttore della classe
        public FormMenu(int tipologia)
        {
            InitializeComponent();
            gridMenu.DataSource = Database.GetInstance().GetCibi();
            gridMenu.AutoGenerateColumns = false;
            this.tipologia = tipologia;
        }

        // Pulsante per scegliere il cibo
        private void BtnConferma_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in gridMenu.Rows)
            {
                if (r.Cells[0].Value != null && int.Parse(r.Cells[0].Value.ToString()) >= 0)
                {
                    CibiSelezionati.Add(new Ordine(int.Parse(r.Cells[0].Value.ToString()), int.Parse(r.Cells[2].Value.ToString())));
                }

            }
            if (tipologia == (int)Prenotazione.EnumTipologia.ASPORTO || tipologia == (int)Prenotazione.EnumTipologia.DOMICILIO)
            {
                FormRegistraCliente registraCliente = new FormRegistraCliente(tipologia);
                registraCliente.Selezione = CibiSelezionati;

                // se prima si preme sul pulsante indietro, questa form non si chiude
                if (registraCliente.ShowDialog() != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                // in questo caso invce si deve chiudere sempre
                this.Close();
            }
        }

        // Quando viene modificata una cella
        private void GridMenu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            listRiepilogo.Items.Clear();
            float totale = 0;

            foreach (DataGridViewRow r in gridMenu.Rows)
            {
                // controlla se la cella "Selezionato" e' stata selezionata o meno
                if (r.Cells[1].Value != null && (bool)r.Cells[1].Value)
                {
                    // se e' stata selezionata, allora automaticamente setta la quantita' del cibo a 1
                    if (r.Cells[0].Value == null || int.Parse(r.Cells[0].Value.ToString()) <= 0)
                    {
                        r.Cells[0].Value = 1;
                    }
                }
                else
                {
                    // altrimenti rimane nulla
                    r.Cells[0].Value = null;
                }
               
                // prendo la riga della quantita' perche e' l'unica che modifico
                if (r.Cells[0].Value != null && int.Parse(r.Cells[0].Value.ToString()) > 0)
                {
                    // aggiunge i campi nome cibo, quantita' e prezzo nel riepilogo
                    listRiepilogo.Items.Add(new ListViewItem(new[] { r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[0].Value.ToString() }));
                    // calcola il conto totale sommando il prezzo del cibo con la quantita'
                    totale += float.Parse(r.Cells[4].Value.ToString()) * int.Parse(r.Cells[0].Value.ToString());
                }
            }
            lblEuro.Text = totale.ToString() + "€";
        }


        // Quando finisco di modificare una cella, in questo caso se e' stato selezionato il cibo
        private void GridMenu_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == gridMenu.Columns[1].Index)
            {
                gridMenu.EndEdit();
            }
        }


        // Pulsante per tornare alla form precedente
        private void BtnIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
