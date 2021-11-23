
namespace GestioneRistorante
{
    partial class FormConcludiPrenotazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConcludiPrenotazione));
            this.lblPrenotazioneEffettuata = new System.Windows.Forms.Label();
            this.btnRitornaHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrenotazioneEffettuata
            // 
            this.lblPrenotazioneEffettuata.AutoSize = true;
            this.lblPrenotazioneEffettuata.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenotazioneEffettuata.Location = new System.Drawing.Point(28, 34);
            this.lblPrenotazioneEffettuata.Name = "lblPrenotazioneEffettuata";
            this.lblPrenotazioneEffettuata.Size = new System.Drawing.Size(287, 19);
            this.lblPrenotazioneEffettuata.TabIndex = 0;
            this.lblPrenotazioneEffettuata.Text = "Prenotazione effettuata con successo!";
            // 
            // btnRitornaHome
            // 
            this.btnRitornaHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRitornaHome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRitornaHome.Location = new System.Drawing.Point(103, 75);
            this.btnRitornaHome.Name = "btnRitornaHome";
            this.btnRitornaHome.Size = new System.Drawing.Size(132, 37);
            this.btnRitornaHome.TabIndex = 2;
            this.btnRitornaHome.Text = "Ritorna alla home";
            this.btnRitornaHome.UseVisualStyleBackColor = false;
            this.btnRitornaHome.Click += new System.EventHandler(this.btnRitornaHome_Click);
            // 
            // FormConcludiPrenotazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 170);
            this.Controls.Add(this.btnRitornaHome);
            this.Controls.Add(this.lblPrenotazioneEffettuata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConcludiPrenotazione";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConcludiPrenotazione";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenotazioneEffettuata;
        private System.Windows.Forms.Button btnRitornaHome;
    }
}