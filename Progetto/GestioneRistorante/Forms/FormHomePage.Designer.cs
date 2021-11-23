
namespace GestioneRistorante
{
    partial class FormHomePage
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomePage));
            this.lblSceltaHomePage = new System.Windows.Forms.Label();
            this.btnOrdinaAsporto = new System.Windows.Forms.Button();
            this.btnPrenotaTavolo = new System.Windows.Forms.Button();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.btnListaTavoli = new System.Windows.Forms.Button();
            this.btnListaPrenotazioni = new System.Windows.Forms.Button();
            this.lblOrdinazione = new System.Windows.Forms.Label();
            this.lblVisualizza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSceltaHomePage
            // 
            this.lblSceltaHomePage.AutoSize = true;
            this.lblSceltaHomePage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSceltaHomePage.Location = new System.Drawing.Point(127, 26);
            this.lblSceltaHomePage.Name = "lblSceltaHomePage";
            this.lblSceltaHomePage.Size = new System.Drawing.Size(259, 24);
            this.lblSceltaHomePage.TabIndex = 0;
            this.lblSceltaHomePage.Text = "Scegli l\'opzione desiderata:";
            this.lblSceltaHomePage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOrdinaAsporto
            // 
            this.btnOrdinaAsporto.BackColor = System.Drawing.Color.LightCyan;
            this.btnOrdinaAsporto.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdinaAsporto.Location = new System.Drawing.Point(24, 113);
            this.btnOrdinaAsporto.Name = "btnOrdinaAsporto";
            this.btnOrdinaAsporto.Size = new System.Drawing.Size(142, 38);
            this.btnOrdinaAsporto.TabIndex = 1;
            this.btnOrdinaAsporto.Text = "ASPORTO";
            this.btnOrdinaAsporto.UseVisualStyleBackColor = false;
            this.btnOrdinaAsporto.Click += new System.EventHandler(this.BtnOrdinaAsporto_Click);
            // 
            // btnPrenotaTavolo
            // 
            this.btnPrenotaTavolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrenotaTavolo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenotaTavolo.Location = new System.Drawing.Point(359, 113);
            this.btnPrenotaTavolo.Name = "btnPrenotaTavolo";
            this.btnPrenotaTavolo.Size = new System.Drawing.Size(142, 38);
            this.btnPrenotaTavolo.TabIndex = 2;
            this.btnPrenotaTavolo.Text = "TAVOLO";
            this.btnPrenotaTavolo.UseVisualStyleBackColor = false;
            this.btnPrenotaTavolo.Click += new System.EventHandler(this.BtnPrenotaTavolo_Click);
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDomicilio.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDomicilio.Location = new System.Drawing.Point(192, 113);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(142, 38);
            this.btnDomicilio.TabIndex = 3;
            this.btnDomicilio.Text = "DOMICILIO";
            this.btnDomicilio.UseVisualStyleBackColor = false;
            this.btnDomicilio.Click += new System.EventHandler(this.BtnDomicilio_Click);
            // 
            // btnListaTavoli
            // 
            this.btnListaTavoli.BackColor = System.Drawing.Color.Beige;
            this.btnListaTavoli.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaTavoli.Location = new System.Drawing.Point(282, 224);
            this.btnListaTavoli.Name = "btnListaTavoli";
            this.btnListaTavoli.Size = new System.Drawing.Size(142, 38);
            this.btnListaTavoli.TabIndex = 4;
            this.btnListaTavoli.Text = "Lista tavoli";
            this.btnListaTavoli.UseVisualStyleBackColor = false;
            this.btnListaTavoli.Click += new System.EventHandler(this.BtnListaTavoli_Click);
            // 
            // btnListaPrenotazioni
            // 
            this.btnListaPrenotazioni.BackColor = System.Drawing.Color.Beige;
            this.btnListaPrenotazioni.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPrenotazioni.Location = new System.Drawing.Point(115, 224);
            this.btnListaPrenotazioni.Name = "btnListaPrenotazioni";
            this.btnListaPrenotazioni.Size = new System.Drawing.Size(142, 38);
            this.btnListaPrenotazioni.TabIndex = 6;
            this.btnListaPrenotazioni.Text = "Lista prenotazoni";
            this.btnListaPrenotazioni.UseVisualStyleBackColor = false;
            this.btnListaPrenotazioni.Click += new System.EventHandler(this.BtnListaPrenotazioni_Click);
            // 
            // lblOrdinazione
            // 
            this.lblOrdinazione.AutoSize = true;
            this.lblOrdinazione.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinazione.Location = new System.Drawing.Point(165, 71);
            this.lblOrdinazione.Name = "lblOrdinazione";
            this.lblOrdinazione.Size = new System.Drawing.Size(197, 19);
            this.lblOrdinazione.TabIndex = 7;
            this.lblOrdinazione.Text = "Modalita di prenotazione:";
            // 
            // lblVisualizza
            // 
            this.lblVisualizza.AutoSize = true;
            this.lblVisualizza.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizza.Location = new System.Drawing.Point(225, 188);
            this.lblVisualizza.Name = "lblVisualizza";
            this.lblVisualizza.Size = new System.Drawing.Size(81, 19);
            this.lblVisualizza.TabIndex = 8;
            this.lblVisualizza.Text = "Visualizza:";
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 293);
            this.Controls.Add(this.lblVisualizza);
            this.Controls.Add(this.lblOrdinazione);
            this.Controls.Add(this.btnListaPrenotazioni);
            this.Controls.Add(this.btnListaTavoli);
            this.Controls.Add(this.btnDomicilio);
            this.Controls.Add(this.btnPrenotaTavolo);
            this.Controls.Add(this.btnOrdinaAsporto);
            this.Controls.Add(this.lblSceltaHomePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSceltaHomePage;
        private System.Windows.Forms.Button btnOrdinaAsporto;
        private System.Windows.Forms.Button btnPrenotaTavolo;
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.Button btnListaTavoli;
        private System.Windows.Forms.Button btnListaPrenotazioni;
        private System.Windows.Forms.Label lblOrdinazione;
        private System.Windows.Forms.Label lblVisualizza;
    }
}

