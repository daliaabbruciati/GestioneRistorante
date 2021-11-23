
namespace GestioneRistorante
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.pnlRiepilogo = new System.Windows.Forms.Panel();
            this.lblEuro = new System.Windows.Forms.Label();
            this.listRiepilogo = new System.Windows.Forms.ListView();
            this.Cibo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Porzioni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotale = new System.Windows.Forms.Label();
            this.lblRiepilogo = new System.Windows.Forms.Label();
            this.gridMenu = new System.Windows.Forms.DataGridView();
            this.Selezionato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Quantita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezzoCibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipologiaCibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vegetariano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRiepilogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(13, 14);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(129, 17);
            this.lblMenu.TabIndex = 7;
            this.lblMenu.Text = "Scegli cosa ordinare:";
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIndietro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIndietro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndietro.Location = new System.Drawing.Point(12, 301);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(85, 32);
            this.btnIndietro.TabIndex = 14;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.BtnIndietro_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConferma.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.Location = new System.Drawing.Point(233, 301);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(88, 32);
            this.btnConferma.TabIndex = 13;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.BtnConferma_Click);
            // 
            // pnlRiepilogo
            // 
            this.pnlRiepilogo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlRiepilogo.Controls.Add(this.btnIndietro);
            this.pnlRiepilogo.Controls.Add(this.lblEuro);
            this.pnlRiepilogo.Controls.Add(this.btnConferma);
            this.pnlRiepilogo.Controls.Add(this.listRiepilogo);
            this.pnlRiepilogo.Controls.Add(this.lblTotale);
            this.pnlRiepilogo.Location = new System.Drawing.Point(702, 34);
            this.pnlRiepilogo.Name = "pnlRiepilogo";
            this.pnlRiepilogo.Size = new System.Drawing.Size(335, 353);
            this.pnlRiepilogo.TabIndex = 15;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(72, 253);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(18, 19);
            this.lblEuro.TabIndex = 19;
            this.lblEuro.Text = "0";
            // 
            // listRiepilogo
            // 
            this.listRiepilogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cibo,
            this.Prezzo,
            this.Porzioni});
            this.listRiepilogo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRiepilogo.HideSelection = false;
            this.listRiepilogo.Location = new System.Drawing.Point(12, 13);
            this.listRiepilogo.Name = "listRiepilogo";
            this.listRiepilogo.Size = new System.Drawing.Size(309, 219);
            this.listRiepilogo.TabIndex = 18;
            this.listRiepilogo.UseCompatibleStateImageBehavior = false;
            this.listRiepilogo.View = System.Windows.Forms.View.Details;
            // 
            // Cibo
            // 
            this.Cibo.Text = "Cibo";
            this.Cibo.Width = 190;
            // 
            // Prezzo
            // 
            this.Prezzo.Text = "Prezzo";
            this.Prezzo.Width = 50;
            // 
            // Porzioni
            // 
            this.Porzioni.Text = "Porzioni";
            this.Porzioni.Width = 55;
            // 
            // lblTotale
            // 
            this.lblTotale.AutoSize = true;
            this.lblTotale.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotale.Location = new System.Drawing.Point(8, 253);
            this.lblTotale.Name = "lblTotale";
            this.lblTotale.Size = new System.Drawing.Size(59, 19);
            this.lblTotale.TabIndex = 8;
            this.lblTotale.Text = "Totale:";
            // 
            // lblRiepilogo
            // 
            this.lblRiepilogo.AutoSize = true;
            this.lblRiepilogo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiepilogo.Location = new System.Drawing.Point(724, 14);
            this.lblRiepilogo.Name = "lblRiepilogo";
            this.lblRiepilogo.Size = new System.Drawing.Size(106, 17);
            this.lblRiepilogo.TabIndex = 16;
            this.lblRiepilogo.Text = "Riepilogo ordine";
            // 
            // gridMenu
            // 
            this.gridMenu.AllowUserToAddRows = false;
            this.gridMenu.AllowUserToDeleteRows = false;
            this.gridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selezionato,
            this.Quantita,
            this.NomeCibo,
            this.PrezzoCibo,
            this.TipologiaCibo,
            this.Vegetariano,
            this.IDCibo});
            this.gridMenu.Location = new System.Drawing.Point(16, 34);
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.Size = new System.Drawing.Size(667, 460);
            this.gridMenu.TabIndex = 17;
            this.gridMenu.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMenu_CellEndEdit);
            this.gridMenu.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridMenu_CellMouseUp);
            // 
            // Selezionato
            // 
            this.Selezionato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Selezionato.DataPropertyName = "IsSelect";
            this.Selezionato.Frozen = true;
            this.Selezionato.HeaderText = "Selezionato";
            this.Selezionato.Name = "Selezionato";
            this.Selezionato.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Selezionato.Width = 68;
            // 
            // Quantita
            // 
            this.Quantita.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantita.DataPropertyName = "Quantita";
            this.Quantita.HeaderText = "Quantita";
            this.Quantita.Name = "Quantita";
            this.Quantita.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantita.Width = 72;
            // 
            // NomeCibo
            // 
            this.NomeCibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NomeCibo.DataPropertyName = "NomeCibo";
            this.NomeCibo.HeaderText = "Nome cibo";
            this.NomeCibo.Name = "NomeCibo";
            this.NomeCibo.ReadOnly = true;
            this.NomeCibo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeCibo.Width = 83;
            // 
            // PrezzoCibo
            // 
            this.PrezzoCibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PrezzoCibo.DataPropertyName = "PrezzoCibo";
            this.PrezzoCibo.HeaderText = "Prezzo cibo";
            this.PrezzoCibo.Name = "PrezzoCibo";
            this.PrezzoCibo.ReadOnly = true;
            this.PrezzoCibo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrezzoCibo.Width = 87;
            // 
            // TipologiaCibo
            // 
            this.TipologiaCibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipologiaCibo.DataPropertyName = "TipologiaCibo";
            this.TipologiaCibo.HeaderText = "Tipologia";
            this.TipologiaCibo.Name = "TipologiaCibo";
            this.TipologiaCibo.ReadOnly = true;
            this.TipologiaCibo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TipologiaCibo.Width = 75;
            // 
            // Vegetariano
            // 
            this.Vegetariano.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Vegetariano.DataPropertyName = "DisplayVegetariano";
            this.Vegetariano.HeaderText = "Vegetariano";
            this.Vegetariano.Name = "Vegetariano";
            this.Vegetariano.ReadOnly = true;
            this.Vegetariano.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Vegetariano.Width = 89;
            // 
            // IDCibo
            // 
            this.IDCibo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IDCibo.DataPropertyName = "IDCibo";
            this.IDCibo.HeaderText = "Id Cibo";
            this.IDCibo.Name = "IDCibo";
            this.IDCibo.ReadOnly = true;
            this.IDCibo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDCibo.Width = 65;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 544);
            this.Controls.Add(this.gridMenu);
            this.Controls.Add(this.lblRiepilogo);
            this.Controls.Add(this.pnlRiepilogo);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.pnlRiepilogo.ResumeLayout(false);
            this.pnlRiepilogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Panel pnlRiepilogo;
        private System.Windows.Forms.Label lblTotale;
        private System.Windows.Forms.Label lblRiepilogo;
        private System.Windows.Forms.ListView listRiepilogo;
        private System.Windows.Forms.DataGridView gridMenu;
    
       
        private System.Windows.Forms.ColumnHeader Prezzo;
        private System.Windows.Forms.ColumnHeader Porzioni;
        private System.Windows.Forms.Label lblEuro;
        internal System.Windows.Forms.ColumnHeader Cibo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selezionato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantita;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezzoCibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipologiaCibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vegetariano;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCibo;
    }
}