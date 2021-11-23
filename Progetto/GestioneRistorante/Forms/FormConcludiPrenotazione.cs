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
    public partial class FormConcludiPrenotazione : Form
    {
        // Costruttore della classe
        public FormConcludiPrenotazione()
        {
            InitializeComponent();
        }

        // Pulsante per ritornare alla schermata Home
        private void btnRitornaHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
