
namespace GestioneRistorante
{
    partial class FormInfoPrenotazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoPrenotazione));
            this.pnlModifica = new System.Windows.Forms.Panel();
            this.cmbTipologia = new System.Windows.Forms.ComboBox();
            this.lblTipologiaModifica = new System.Windows.Forms.Label();
            this.cmbStato = new System.Windows.Forms.ComboBox();
            this.lblStatoModifica = new System.Windows.Forms.Label();
            this.lblNumPersone = new System.Windows.Forms.Label();
            this.numPersone = new System.Windows.Forms.NumericUpDown();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNoteModifica = new System.Windows.Forms.TextBox();
            this.oraModifica = new System.Windows.Forms.DateTimePicker();
            this.lblOra = new System.Windows.Forms.Label();
            this.dataModifica = new System.Windows.Forms.DateTimePicker();
            this.btnAnnullaModifica = new System.Windows.Forms.Button();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.lblRecapito = new System.Windows.Forms.Label();
            this.lblOrario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtIndirizzoModifica = new System.Windows.Forms.TextBox();
            this.txtRecapitoModifica = new System.Windows.Forms.TextBox();
            this.txtNomeModifica = new System.Windows.Forms.TextBox();
            this.btnConfermaModifica = new System.Windows.Forms.Button();
            this.pnlInfoOrdine = new System.Windows.Forms.Panel();
            this.btnPaga = new System.Windows.Forms.Button();
            this.btnAzzeraAttesa = new System.Windows.Forms.Button();
            this.lblTempoAttesa = new System.Windows.Forms.Label();
            this.txtTempoAttesa = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblTotale = new System.Windows.Forms.Label();
            this.listViewOrdine = new System.Windows.Forms.ListView();
            this.IdCibo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCibo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipologia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vegetariano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAggiungiCibo = new System.Windows.Forms.Button();
            this.lblNumPosti = new System.Windows.Forms.Label();
            this.txtNumPosti = new System.Windows.Forms.TextBox();
            this.lblNumTavolo = new System.Windows.Forms.Label();
            this.txtNumTavolo = new System.Windows.Forms.TextBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.lblZona = new System.Windows.Forms.Label();
            this.pnlModifica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPersone)).BeginInit();
            this.pnlInfoOrdine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlModifica
            // 
            this.pnlModifica.Controls.Add(this.cmbTipologia);
            this.pnlModifica.Controls.Add(this.lblTipologiaModifica);
            this.pnlModifica.Controls.Add(this.cmbStato);
            this.pnlModifica.Controls.Add(this.lblStatoModifica);
            this.pnlModifica.Controls.Add(this.lblNumPersone);
            this.pnlModifica.Controls.Add(this.numPersone);
            this.pnlModifica.Controls.Add(this.lblNote);
            this.pnlModifica.Controls.Add(this.txtNoteModifica);
            this.pnlModifica.Controls.Add(this.oraModifica);
            this.pnlModifica.Controls.Add(this.lblOra);
            this.pnlModifica.Controls.Add(this.dataModifica);
            this.pnlModifica.Controls.Add(this.btnAnnullaModifica);
            this.pnlModifica.Controls.Add(this.lblIndirizzo);
            this.pnlModifica.Controls.Add(this.lblRecapito);
            this.pnlModifica.Controls.Add(this.lblOrario);
            this.pnlModifica.Controls.Add(this.lblNome);
            this.pnlModifica.Controls.Add(this.txtIndirizzoModifica);
            this.pnlModifica.Controls.Add(this.txtRecapitoModifica);
            this.pnlModifica.Controls.Add(this.txtNomeModifica);
            this.pnlModifica.Location = new System.Drawing.Point(12, 12);
            this.pnlModifica.Name = "pnlModifica";
            this.pnlModifica.Size = new System.Drawing.Size(225, 492);
            this.pnlModifica.TabIndex = 28;
            // 
            // cmbTipologia
            // 
            this.cmbTipologia.Enabled = false;
            this.cmbTipologia.FormattingEnabled = true;
            this.cmbTipologia.Items.AddRange(new object[] {
            "Asporto",
            "Domicilio",
            "Al tavolo"});
            this.cmbTipologia.Location = new System.Drawing.Point(12, 303);
            this.cmbTipologia.Name = "cmbTipologia";
            this.cmbTipologia.Size = new System.Drawing.Size(134, 21);
            this.cmbTipologia.TabIndex = 41;
            // 
            // lblTipologiaModifica
            // 
            this.lblTipologiaModifica.AutoSize = true;
            this.lblTipologiaModifica.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipologiaModifica.Location = new System.Drawing.Point(9, 286);
            this.lblTipologiaModifica.Name = "lblTipologiaModifica";
            this.lblTipologiaModifica.Size = new System.Drawing.Size(59, 14);
            this.lblTipologiaModifica.TabIndex = 40;
            this.lblTipologiaModifica.Text = "Tipologia:";
            // 
            // cmbStato
            // 
            this.cmbStato.FormattingEnabled = true;
            this.cmbStato.Items.AddRange(new object[] {
            "In attesa",
            "Da pagare",
            "Terminato"});
            this.cmbStato.Location = new System.Drawing.Point(12, 222);
            this.cmbStato.Name = "cmbStato";
            this.cmbStato.Size = new System.Drawing.Size(134, 21);
            this.cmbStato.TabIndex = 39;
            // 
            // lblStatoModifica
            // 
            this.lblStatoModifica.AutoSize = true;
            this.lblStatoModifica.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatoModifica.Location = new System.Drawing.Point(9, 204);
            this.lblStatoModifica.Name = "lblStatoModifica";
            this.lblStatoModifica.Size = new System.Drawing.Size(37, 14);
            this.lblStatoModifica.TabIndex = 38;
            this.lblStatoModifica.Text = "Stato:";
            // 
            // lblNumPersone
            // 
            this.lblNumPersone.AutoSize = true;
            this.lblNumPersone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPersone.Location = new System.Drawing.Point(11, 46);
            this.lblNumPersone.Name = "lblNumPersone";
            this.lblNumPersone.Size = new System.Drawing.Size(111, 14);
            this.lblNumPersone.TabIndex = 37;
            this.lblNumPersone.Text = "Numero di persone:";
            // 
            // numPersone
            // 
            this.numPersone.Location = new System.Drawing.Point(14, 63);
            this.numPersone.Name = "numPersone";
            this.numPersone.Size = new System.Drawing.Size(134, 20);
            this.numPersone.TabIndex = 36;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(9, 327);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 14);
            this.lblNote.TabIndex = 35;
            this.lblNote.Text = "Note";
            // 
            // txtNoteModifica
            // 
            this.txtNoteModifica.Location = new System.Drawing.Point(12, 344);
            this.txtNoteModifica.Multiline = true;
            this.txtNoteModifica.Name = "txtNoteModifica";
            this.txtNoteModifica.Size = new System.Drawing.Size(195, 78);
            this.txtNoteModifica.TabIndex = 34;
            // 
            // oraModifica
            // 
            this.oraModifica.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.oraModifica.Location = new System.Drawing.Point(14, 181);
            this.oraModifica.Name = "oraModifica";
            this.oraModifica.ShowUpDown = true;
            this.oraModifica.Size = new System.Drawing.Size(134, 20);
            this.oraModifica.TabIndex = 33;
            this.oraModifica.UseWaitCursor = true;
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.Location = new System.Drawing.Point(11, 164);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(62, 14);
            this.lblOra.TabIndex = 32;
            this.lblOra.Text = "Ora arrivo:";
            // 
            // dataModifica
            // 
            this.dataModifica.Location = new System.Drawing.Point(14, 141);
            this.dataModifica.Name = "dataModifica";
            this.dataModifica.Size = new System.Drawing.Size(134, 20);
            this.dataModifica.TabIndex = 31;
            // 
            // btnAnnullaModifica
            // 
            this.btnAnnullaModifica.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnnullaModifica.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnullaModifica.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaModifica.Location = new System.Drawing.Point(12, 445);
            this.btnAnnullaModifica.Name = "btnAnnullaModifica";
            this.btnAnnullaModifica.Size = new System.Drawing.Size(85, 32);
            this.btnAnnullaModifica.TabIndex = 30;
            this.btnAnnullaModifica.Text = "Indietro";
            this.btnAnnullaModifica.UseVisualStyleBackColor = false;
            this.btnAnnullaModifica.Click += new System.EventHandler(this.BtnAnnullaModifica_Click);
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndirizzo.Location = new System.Drawing.Point(9, 246);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(51, 14);
            this.lblIndirizzo.TabIndex = 28;
            this.lblIndirizzo.Text = "Indirizzo";
            // 
            // lblRecapito
            // 
            this.lblRecapito.AutoSize = true;
            this.lblRecapito.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapito.Location = new System.Drawing.Point(9, 86);
            this.lblRecapito.Name = "lblRecapito";
            this.lblRecapito.Size = new System.Drawing.Size(107, 14);
            this.lblRecapito.TabIndex = 27;
            this.lblRecapito.Text = "Recapito telefonico";
            // 
            // lblOrario
            // 
            this.lblOrario.AutoSize = true;
            this.lblOrario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrario.Location = new System.Drawing.Point(11, 125);
            this.lblOrario.Name = "lblOrario";
            this.lblOrario.Size = new System.Drawing.Size(31, 14);
            this.lblOrario.TabIndex = 26;
            this.lblOrario.Text = "Data";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(11, 6);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Nome";
            // 
            // txtIndirizzoModifica
            // 
            this.txtIndirizzoModifica.Location = new System.Drawing.Point(12, 263);
            this.txtIndirizzoModifica.Name = "txtIndirizzoModifica";
            this.txtIndirizzoModifica.Size = new System.Drawing.Size(134, 20);
            this.txtIndirizzoModifica.TabIndex = 24;
            // 
            // txtRecapitoModifica
            // 
            this.txtRecapitoModifica.Location = new System.Drawing.Point(12, 102);
            this.txtRecapitoModifica.Name = "txtRecapitoModifica";
            this.txtRecapitoModifica.Size = new System.Drawing.Size(134, 20);
            this.txtRecapitoModifica.TabIndex = 23;
            // 
            // txtNomeModifica
            // 
            this.txtNomeModifica.Location = new System.Drawing.Point(12, 22);
            this.txtNomeModifica.Name = "txtNomeModifica";
            this.txtNomeModifica.Size = new System.Drawing.Size(134, 20);
            this.txtNomeModifica.TabIndex = 22;
            // 
            // btnConfermaModifica
            // 
            this.btnConfermaModifica.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnConfermaModifica.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfermaModifica.Location = new System.Drawing.Point(262, 445);
            this.btnConfermaModifica.Name = "btnConfermaModifica";
            this.btnConfermaModifica.Size = new System.Drawing.Size(127, 31);
            this.btnConfermaModifica.TabIndex = 29;
            this.btnConfermaModifica.Text = "Conferma modifica";
            this.btnConfermaModifica.UseVisualStyleBackColor = false;
            this.btnConfermaModifica.Click += new System.EventHandler(this.BtnConfermaModifica_Click);
            // 
            // pnlInfoOrdine
            // 
            this.pnlInfoOrdine.Controls.Add(this.btnPaga);
            this.pnlInfoOrdine.Controls.Add(this.btnAzzeraAttesa);
            this.pnlInfoOrdine.Controls.Add(this.lblTempoAttesa);
            this.pnlInfoOrdine.Controls.Add(this.txtTempoAttesa);
            this.pnlInfoOrdine.Controls.Add(this.lblEuro);
            this.pnlInfoOrdine.Controls.Add(this.lblTotale);
            this.pnlInfoOrdine.Controls.Add(this.listViewOrdine);
            this.pnlInfoOrdine.Controls.Add(this.btnAggiungiCibo);
            this.pnlInfoOrdine.Controls.Add(this.lblNumPosti);
            this.pnlInfoOrdine.Controls.Add(this.txtNumPosti);
            this.pnlInfoOrdine.Controls.Add(this.lblNumTavolo);
            this.pnlInfoOrdine.Controls.Add(this.txtNumTavolo);
            this.pnlInfoOrdine.Controls.Add(this.btnConfermaModifica);
            this.pnlInfoOrdine.Controls.Add(this.cmbZona);
            this.pnlInfoOrdine.Controls.Add(this.lblZona);
            this.pnlInfoOrdine.Location = new System.Drawing.Point(258, 12);
            this.pnlInfoOrdine.Name = "pnlInfoOrdine";
            this.pnlInfoOrdine.Size = new System.Drawing.Size(501, 486);
            this.pnlInfoOrdine.TabIndex = 29;
            // 
            // btnPaga
            // 
            this.btnPaga.BackColor = System.Drawing.Color.Red;
            this.btnPaga.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaga.Location = new System.Drawing.Point(395, 445);
            this.btnPaga.Name = "btnPaga";
            this.btnPaga.Size = new System.Drawing.Size(88, 32);
            this.btnPaga.TabIndex = 54;
            this.btnPaga.Text = "Paga";
            this.btnPaga.UseVisualStyleBackColor = false;
            this.btnPaga.Click += new System.EventHandler(this.BtnPaga_Click);
            // 
            // btnAzzeraAttesa
            // 
            this.btnAzzeraAttesa.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAzzeraAttesa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzzeraAttesa.Location = new System.Drawing.Point(157, 56);
            this.btnAzzeraAttesa.Name = "btnAzzeraAttesa";
            this.btnAzzeraAttesa.Size = new System.Drawing.Size(114, 32);
            this.btnAzzeraAttesa.TabIndex = 53;
            this.btnAzzeraAttesa.Text = "Azzera attesa";
            this.btnAzzeraAttesa.UseVisualStyleBackColor = false;
            this.btnAzzeraAttesa.Click += new System.EventHandler(this.BtnAzzeraAttesa_Click);
            // 
            // lblTempoAttesa
            // 
            this.lblTempoAttesa.AutoSize = true;
            this.lblTempoAttesa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoAttesa.Location = new System.Drawing.Point(18, 46);
            this.lblTempoAttesa.Name = "lblTempoAttesa";
            this.lblTempoAttesa.Size = new System.Drawing.Size(108, 14);
            this.lblTempoAttesa.TabIndex = 52;
            this.lblTempoAttesa.Text = "Tempo attesa (min)";
            // 
            // txtTempoAttesa
            // 
            this.txtTempoAttesa.Location = new System.Drawing.Point(17, 63);
            this.txtTempoAttesa.Name = "txtTempoAttesa";
            this.txtTempoAttesa.ReadOnly = true;
            this.txtTempoAttesa.Size = new System.Drawing.Size(134, 20);
            this.txtTempoAttesa.TabIndex = 51;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(86, 451);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(18, 19);
            this.lblEuro.TabIndex = 50;
            this.lblEuro.Text = "0";
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(22, 451);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(59, 19);
            this.lblTotale.TabIndex = 49;
            this.lblTotale.Text = "Totale:";
            // 
            // listViewOrdine
            // 
            this.listViewOrdine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCibo,
            this.NomeCibo,
            this.Quantita,
            this.Prezzo,
            this.Tipologia,
            this.Vegetariano});
            this.listViewOrdine.FullRowSelect = true;
            this.listViewOrdine.GridLines = true;
            this.listViewOrdine.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrdine.HideSelection = false;
            this.listViewOrdine.LabelWrap = false;
            this.listViewOrdine.Location = new System.Drawing.Point(17, 110);
            this.listViewOrdine.Name = "listViewOrdine";
            this.listViewOrdine.Size = new System.Drawing.Size(466, 324);
            this.listViewOrdine.TabIndex = 48;
            this.listViewOrdine.UseCompatibleStateImageBehavior = false;
            this.listViewOrdine.View = System.Windows.Forms.View.Details;
            // 
            // IdCibo
            // 
            this.IdCibo.Text = "IdCibo";
            this.IdCibo.Width = 50;
            // 
            // NomeCibo
            // 
            this.NomeCibo.Text = "NomeCibo";
            this.NomeCibo.Width = 100;
            // 
            // Quantita
            // 
            this.Quantita.Text = "Quantita";
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            this.Prezzo.Width = 50;
            // 
            // Tipologia
            // 
            this.Tipologia.Text = "Tipologia";
            // 
            // Vegetariano
            // 
            this.Vegetariano.Text = "Vegetariano";
            this.Vegetariano.Width = 70;
            // 
            // btnAggiungiCibo
            // 
            this.btnAggiungiCibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAggiungiCibo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAggiungiCibo.Location = new System.Drawing.Point(152, 446);
            this.btnAggiungiCibo.Name = "btnAggiungiCibo";
            this.btnAggiungiCibo.Size = new System.Drawing.Size(104, 30);
            this.btnAggiungiCibo.TabIndex = 42;
            this.btnAggiungiCibo.Text = "Aggiungi cibo";
            this.btnAggiungiCibo.UseVisualStyleBackColor = false;
            this.btnAggiungiCibo.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // lblNumPosti
            // 
            this.lblNumPosti.AutoSize = true;
            this.lblNumPosti.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPosti.Location = new System.Drawing.Point(294, 6);
            this.lblNumPosti.Name = "lblNumPosti";
            this.lblNumPosti.Size = new System.Drawing.Size(79, 14);
            this.lblNumPosti.TabIndex = 46;
            this.lblNumPosti.Text = "Numero posti";
            // 
            // txtNumPosti
            // 
            this.txtNumPosti.Location = new System.Drawing.Point(297, 22);
            this.txtNumPosti.Name = "txtNumPosti";
            this.txtNumPosti.ReadOnly = true;
            this.txtNumPosti.Size = new System.Drawing.Size(134, 20);
            this.txtNumPosti.TabIndex = 45;
            // 
            // lblNumTavolo
            // 
            this.lblNumTavolo.AutoSize = true;
            this.lblNumTavolo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTavolo.Location = new System.Drawing.Point(14, 6);
            this.lblNumTavolo.Name = "lblNumTavolo";
            this.lblNumTavolo.Size = new System.Drawing.Size(86, 14);
            this.lblNumTavolo.TabIndex = 44;
            this.lblNumTavolo.Text = "Numero tavolo";
            // 
            // txtNumTavolo
            // 
            this.txtNumTavolo.Location = new System.Drawing.Point(17, 22);
            this.txtNumTavolo.Name = "txtNumTavolo";
            this.txtNumTavolo.ReadOnly = true;
            this.txtNumTavolo.Size = new System.Drawing.Size(134, 20);
            this.txtNumTavolo.TabIndex = 42;
            // 
            // cmbZona
            // 
            this.cmbZona.Enabled = false;
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Items.AddRange(new object[] {
            "Portico",
            "Terrazza",
            "Sala interna",
            "Sala esterna",
            "Aperitivo"});
            this.cmbZona.Location = new System.Drawing.Point(157, 22);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(134, 21);
            this.cmbZona.TabIndex = 42;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZona.Location = new System.Drawing.Point(154, 5);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(34, 14);
            this.lblZona.TabIndex = 43;
            this.lblZona.Text = "Zona";
            // 
            // FormInfoPrenotazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 516);
            this.Controls.Add(this.pnlInfoOrdine);
            this.Controls.Add(this.pnlModifica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfoPrenotazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfoPrenotazione";
            this.pnlModifica.ResumeLayout(false);
            this.pnlModifica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPersone)).EndInit();
            this.pnlInfoOrdine.ResumeLayout(false);
            this.pnlInfoOrdine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlModifica;
        private System.Windows.Forms.ComboBox cmbStato;
        private System.Windows.Forms.Label lblStatoModifica;
        private System.Windows.Forms.Label lblNumPersone;
        private System.Windows.Forms.NumericUpDown numPersone;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNoteModifica;
        private System.Windows.Forms.DateTimePicker oraModifica;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.DateTimePicker dataModifica;
        private System.Windows.Forms.Button btnAnnullaModifica;
        private System.Windows.Forms.Button btnConfermaModifica;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.Label lblRecapito;
        private System.Windows.Forms.Label lblOrario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtIndirizzoModifica;
        private System.Windows.Forms.TextBox txtRecapitoModifica;
        private System.Windows.Forms.TextBox txtNomeModifica;
        private System.Windows.Forms.ComboBox cmbTipologia;
        private System.Windows.Forms.Label lblTipologiaModifica;
        private System.Windows.Forms.Panel pnlInfoOrdine;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.Label lblNumPosti;
        private System.Windows.Forms.TextBox txtNumPosti;
        private System.Windows.Forms.Label lblNumTavolo;
        private System.Windows.Forms.TextBox txtNumTavolo;
        private System.Windows.Forms.Button btnAggiungiCibo;
        private System.Windows.Forms.ListView listViewOrdine;
        private System.Windows.Forms.ColumnHeader IdCibo;
        private System.Windows.Forms.ColumnHeader NomeCibo;
        private System.Windows.Forms.ColumnHeader Quantita;
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.ColumnHeader Tipologia;
        private System.Windows.Forms.ColumnHeader Vegetariano;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Button btnAzzeraAttesa;
        private System.Windows.Forms.Label lblTempoAttesa;
        private System.Windows.Forms.TextBox txtTempoAttesa;
        private System.Windows.Forms.Button btnPaga;
    }
}