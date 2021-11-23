
namespace GestioneRistorante
{
    partial class FormListaPrenotazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPrenotazioni));
            this.lViewPrenotazioni = new System.Windows.Forms.ListView();
            this.IDPrenotazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomePrenotazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeroPersone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumeroTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataOra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OraUltimoOrdine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Indirizzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipologia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIndietro = new System.Windows.Forms.Button();
            this.ckAsporto = new System.Windows.Forms.CheckBox();
            this.ckDomicilio = new System.Windows.Forms.CheckBox();
            this.ckAlTavolo = new System.Windows.Forms.CheckBox();
            this.lblTipologia = new System.Windows.Forms.Label();
            this.lblStato = new System.Windows.Forms.Label();
            this.ckAttesa = new System.Windows.Forms.CheckBox();
            this.ckTerminato = new System.Windows.Forms.CheckBox();
            this.ckDaPagare = new System.Windows.Forms.CheckBox();
            this.smartRestaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnEliminaTutto = new System.Windows.Forms.Button();
            this.prenotazioneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.smartRestaurantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lViewPrenotazioni
            // 
            this.lViewPrenotazioni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDPrenotazione,
            this.NomePrenotazione,
            this.NumeroPersone,
            this.NumeroTelefono,
            this.DataOra,
            this.Stato,
            this.OraUltimoOrdine,
            this.Indirizzo,
            this.Tipologia,
            this.Note});
            this.lViewPrenotazioni.FullRowSelect = true;
            this.lViewPrenotazioni.GridLines = true;
            this.lViewPrenotazioni.HideSelection = false;
            this.lViewPrenotazioni.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lViewPrenotazioni.Location = new System.Drawing.Point(12, 58);
            this.lViewPrenotazioni.Name = "lViewPrenotazioni";
            this.lViewPrenotazioni.Size = new System.Drawing.Size(776, 368);
            this.lViewPrenotazioni.TabIndex = 0;
            this.lViewPrenotazioni.UseCompatibleStateImageBehavior = false;
            this.lViewPrenotazioni.View = System.Windows.Forms.View.Details;
            this.lViewPrenotazioni.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LViewPrenotazioni_MouseDoubleClick);
            // 
            // IDPrenotazione
            // 
            this.IDPrenotazione.Text = "ID Prenotazione";
            this.IDPrenotazione.Width = 120;
            // 
            // NomePrenotazione
            // 
            this.NomePrenotazione.Text = "Nome Prenotazione";
            this.NomePrenotazione.Width = 110;
            // 
            // NumeroPersone
            // 
            this.NumeroPersone.Text = "Numero Persone";
            this.NumeroPersone.Width = 100;
            // 
            // NumeroTelefono
            // 
            this.NumeroTelefono.Text = "Numero Telefono";
            this.NumeroTelefono.Width = 100;
            // 
            // DataOra
            // 
            this.DataOra.Text = "Data e ora";
            this.DataOra.Width = 100;
            // 
            // Stato
            // 
            this.Stato.Text = "Stato";
            this.Stato.Width = 100;
            // 
            // OraUltimoOrdine
            // 
            this.OraUltimoOrdine.Text = "Ora ultimo ordine";
            this.OraUltimoOrdine.Width = 130;
            // 
            // Indirizzo
            // 
            this.Indirizzo.Text = "Indirizzo";
            this.Indirizzo.Width = 130;
            // 
            // Tipologia
            // 
            this.Tipologia.Text = "Tipologia";
            this.Tipologia.Width = 100;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 90;
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIndietro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIndietro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndietro.Location = new System.Drawing.Point(703, 441);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(85, 32);
            this.btnIndietro.TabIndex = 15;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.BtnIndietro_Click);
            // 
            // ckAsporto
            // 
            this.ckAsporto.AutoSize = true;
            this.ckAsporto.Checked = true;
            this.ckAsporto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAsporto.Location = new System.Drawing.Point(82, 12);
            this.ckAsporto.Name = "ckAsporto";
            this.ckAsporto.Size = new System.Drawing.Size(62, 17);
            this.ckAsporto.TabIndex = 16;
            this.ckAsporto.Text = "Asporto";
            this.ckAsporto.UseVisualStyleBackColor = true;
            this.ckAsporto.CheckedChanged += new System.EventHandler(this.FiltroCheck);
            // 
            // ckDomicilio
            // 
            this.ckDomicilio.AutoSize = true;
            this.ckDomicilio.Checked = true;
            this.ckDomicilio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDomicilio.Location = new System.Drawing.Point(185, 12);
            this.ckDomicilio.Name = "ckDomicilio";
            this.ckDomicilio.Size = new System.Drawing.Size(68, 17);
            this.ckDomicilio.TabIndex = 17;
            this.ckDomicilio.Text = "Domicilio";
            this.ckDomicilio.UseVisualStyleBackColor = true;
            this.ckDomicilio.CheckedChanged += new System.EventHandler(this.FiltroCheck);
            // 
            // ckAlTavolo
            // 
            this.ckAlTavolo.AutoSize = true;
            this.ckAlTavolo.Checked = true;
            this.ckAlTavolo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAlTavolo.Location = new System.Drawing.Point(290, 12);
            this.ckAlTavolo.Name = "ckAlTavolo";
            this.ckAlTavolo.Size = new System.Drawing.Size(67, 17);
            this.ckAlTavolo.TabIndex = 18;
            this.ckAlTavolo.Text = "Al tavolo";
            this.ckAlTavolo.UseVisualStyleBackColor = true;
            this.ckAlTavolo.CheckedChanged += new System.EventHandler(this.FiltroCheck);
            // 
            // lblTipologia
            // 
            this.lblTipologia.AutoSize = true;
            this.lblTipologia.Location = new System.Drawing.Point(13, 12);
            this.lblTipologia.Name = "lblTipologia";
            this.lblTipologia.Size = new System.Drawing.Size(50, 13);
            this.lblTipologia.TabIndex = 20;
            this.lblTipologia.Text = "Tipologia";
            // 
            // lblStato
            // 
            this.lblStato.AutoSize = true;
            this.lblStato.Location = new System.Drawing.Point(13, 35);
            this.lblStato.Name = "lblStato";
            this.lblStato.Size = new System.Drawing.Size(32, 13);
            this.lblStato.TabIndex = 21;
            this.lblStato.Text = "Stato";
            // 
            // ckAttesa
            // 
            this.ckAttesa.AutoSize = true;
            this.ckAttesa.Checked = true;
            this.ckAttesa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAttesa.Location = new System.Drawing.Point(82, 34);
            this.ckAttesa.Name = "ckAttesa";
            this.ckAttesa.Size = new System.Drawing.Size(67, 17);
            this.ckAttesa.TabIndex = 22;
            this.ckAttesa.Text = "In attesa";
            this.ckAttesa.UseVisualStyleBackColor = true;
            this.ckAttesa.CheckedChanged += new System.EventHandler(this.FiltroCheck);
            // 
            // ckTerminato
            // 
            this.ckTerminato.AutoSize = true;
            this.ckTerminato.Checked = true;
            this.ckTerminato.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTerminato.Location = new System.Drawing.Point(290, 34);
            this.ckTerminato.Name = "ckTerminato";
            this.ckTerminato.Size = new System.Drawing.Size(69, 17);
            this.ckTerminato.TabIndex = 23;
            this.ckTerminato.Text = "Terminati";
            this.ckTerminato.UseVisualStyleBackColor = true;
            this.ckTerminato.CheckedChanged += new System.EventHandler(this.FiltroCheck);
            // 
            // ckDaPagare
            // 
            this.ckDaPagare.AutoSize = true;
            this.ckDaPagare.Checked = true;
            this.ckDaPagare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckDaPagare.Location = new System.Drawing.Point(185, 35);
            this.ckDaPagare.Name = "ckDaPagare";
            this.ckDaPagare.Size = new System.Drawing.Size(76, 17);
            this.ckDaPagare.TabIndex = 24;
            this.ckDaPagare.Text = "Da pagare";
            this.ckDaPagare.UseVisualStyleBackColor = true;
            this.ckDaPagare.CheckedChanged += new System.EventHandler(this.FiltroCheck);
            // 
            // BtnEliminaTutto
            // 
            this.BtnEliminaTutto.BackColor = System.Drawing.Color.Red;
            this.BtnEliminaTutto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEliminaTutto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminaTutto.Location = new System.Drawing.Point(570, 441);
            this.BtnEliminaTutto.Name = "BtnEliminaTutto";
            this.BtnEliminaTutto.Size = new System.Drawing.Size(113, 32);
            this.BtnEliminaTutto.TabIndex = 25;
            this.BtnEliminaTutto.Text = "Elimina tutto";
            this.BtnEliminaTutto.UseVisualStyleBackColor = false;
            this.BtnEliminaTutto.Click += new System.EventHandler(this.BtnEliminaTutto_Click);
            // 
            // prenotazioneBindingSource
            // 
            this.prenotazioneBindingSource.DataSource = typeof(GestioneRistorante.Prenotazione);
            // 
            // FormListaPrenotazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 485);
            this.Controls.Add(this.BtnEliminaTutto);
            this.Controls.Add(this.ckDaPagare);
            this.Controls.Add(this.ckTerminato);
            this.Controls.Add(this.ckAttesa);
            this.Controls.Add(this.lblStato);
            this.Controls.Add(this.lblTipologia);
            this.Controls.Add(this.ckAlTavolo);
            this.Controls.Add(this.ckDomicilio);
            this.Controls.Add(this.ckAsporto);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.lViewPrenotazioni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaPrenotazioni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaPrenotazioni";
            ((System.ComponentModel.ISupportInitialize)(this.smartRestaurantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenotazioneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lViewPrenotazioni;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.ColumnHeader IDPrenotazione;
        private System.Windows.Forms.ColumnHeader NomePrenotazione;
        private System.Windows.Forms.ColumnHeader NumeroPersone;
        private System.Windows.Forms.ColumnHeader NumeroTelefono;
        private System.Windows.Forms.CheckBox ckAsporto;
        private System.Windows.Forms.CheckBox ckDomicilio;
        private System.Windows.Forms.CheckBox ckAlTavolo;
        private System.Windows.Forms.Label lblTipologia;
        private System.Windows.Forms.Label lblStato;
        private System.Windows.Forms.CheckBox ckAttesa;
        private System.Windows.Forms.CheckBox ckTerminato;
        private System.Windows.Forms.CheckBox ckDaPagare;
        private System.Windows.Forms.ColumnHeader DataOra;
        private System.Windows.Forms.ColumnHeader Stato;
        private System.Windows.Forms.ColumnHeader OraUltimoOrdine;
        private System.Windows.Forms.ColumnHeader Indirizzo;
        private System.Windows.Forms.ColumnHeader Tipologia;
        private System.Windows.Forms.BindingSource prenotazioneBindingSource;
       // private SmartRestaurantDataSet smartRestaurantDataSet;
        private System.Windows.Forms.BindingSource smartRestaurantDataSetBindingSource;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.Button BtnEliminaTutto;
    }
}