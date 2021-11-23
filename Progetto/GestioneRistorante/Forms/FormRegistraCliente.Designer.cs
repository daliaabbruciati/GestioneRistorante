
namespace GestioneRistorante
{
    partial class FormRegistraCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistraCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRecapito = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblOrario = new System.Windows.Forms.Label();
            this.lblRecapito = new System.Windows.Forms.Label();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.ora = new System.Windows.Forms.DateTimePicker();
            this.lblOra = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(34, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(195, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtRecapito
            // 
            this.txtRecapito.Location = new System.Drawing.Point(34, 164);
            this.txtRecapito.Name = "txtRecapito";
            this.txtRecapito.Size = new System.Drawing.Size(195, 20);
            this.txtRecapito.TabIndex = 2;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(34, 208);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(195, 20);
            this.txtIndirizzo.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 14);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblOrario
            // 
            this.lblOrario.AutoSize = true;
            this.lblOrario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrario.Location = new System.Drawing.Point(31, 57);
            this.lblOrario.Name = "lblOrario";
            this.lblOrario.Size = new System.Drawing.Size(31, 14);
            this.lblOrario.TabIndex = 5;
            this.lblOrario.Text = "Data";
            // 
            // lblRecapito
            // 
            this.lblRecapito.AutoSize = true;
            this.lblRecapito.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecapito.Location = new System.Drawing.Point(31, 145);
            this.lblRecapito.Name = "lblRecapito";
            this.lblRecapito.Size = new System.Drawing.Size(107, 14);
            this.lblRecapito.TabIndex = 6;
            this.lblRecapito.Text = "Recapito telefonico";
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndirizzo.Location = new System.Drawing.Point(31, 189);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(51, 14);
            this.lblIndirizzo.TabIndex = 7;
            this.lblIndirizzo.Text = "Indirizzo";
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIndietro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIndietro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndietro.Location = new System.Drawing.Point(34, 370);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(85, 32);
            this.btnIndietro.TabIndex = 16;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.BtnIndietro_Click);
            // 
            // btnConferma
            // 
            this.btnConferma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConferma.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferma.Location = new System.Drawing.Point(141, 370);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(88, 32);
            this.btnConferma.TabIndex = 15;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = false;
            this.btnConferma.Click += new System.EventHandler(this.BtnConferma_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(34, 76);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(195, 20);
            this.data.TabIndex = 17;
            // 
            // ora
            // 
            this.ora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ora.Location = new System.Drawing.Point(34, 120);
            this.ora.Name = "ora";
            this.ora.ShowUpDown = true;
            this.ora.Size = new System.Drawing.Size(121, 20);
            this.ora.TabIndex = 19;
            this.ora.UseWaitCursor = true;
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.Location = new System.Drawing.Point(31, 101);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(62, 14);
            this.lblOra.TabIndex = 18;
            this.lblOra.Text = "Ora arrivo:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(34, 252);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(195, 93);
            this.txtNote.TabIndex = 20;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(31, 233);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 14);
            this.lblNote.TabIndex = 21;
            this.lblNote.Text = "Note";
            // 
            // FormRegistraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 424);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.ora);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btnIndietro);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.lblRecapito);
            this.Controls.Add(this.lblOrario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.txtRecapito);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistraCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistraCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRecapito;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblOrario;
        private System.Windows.Forms.Label lblRecapito;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.DateTimePicker ora;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label lblNote;
    }
}