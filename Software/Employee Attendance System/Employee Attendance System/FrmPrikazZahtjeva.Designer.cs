namespace Employee_Attendance_System
{
    partial class FrmPrikazZahtjeva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrikazZahtjeva));
            this.lblKreiraniZahtjevi = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKreiraniZahtjevi
            // 
            this.lblKreiraniZahtjevi.AutoSize = true;
            this.lblKreiraniZahtjevi.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKreiraniZahtjevi.Location = new System.Drawing.Point(21, 27);
            this.lblKreiraniZahtjevi.Name = "lblKreiraniZahtjevi";
            this.lblKreiraniZahtjevi.Size = new System.Drawing.Size(178, 25);
            this.lblKreiraniZahtjevi.TabIndex = 0;
            this.lblKreiraniZahtjevi.Text = "Kreirani zahtjevi";
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.BackColor = System.Drawing.SystemColors.Window;
            this.txtPretrazivanje.Location = new System.Drawing.Point(575, 27);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(206, 20);
            this.txtPretrazivanje.TabIndex = 1;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.txtPretrazivanje_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(572, 8);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(98, 16);
            this.lblPretrazivanje.TabIndex = 2;
            this.lblPretrazivanje.Text = "Pretraživanje";
            // 
            // btnNovi
            // 
            this.btnNovi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNovi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovi.Location = new System.Drawing.Point(480, 399);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(103, 35);
            this.btnNovi.TabIndex = 3;
            this.btnNovi.Text = "Novi Zahtjev";
            this.btnNovi.UseVisualStyleBackColor = false;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnObrisi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.Location = new System.Drawing.Point(698, 399);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(103, 35);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši ";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIzmijeni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.Location = new System.Drawing.Point(589, 399);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(103, 35);
            this.btnIzmijeni.TabIndex = 5;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(29, 64);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.ReadOnly = true;
            this.dgvZahtjevi.Size = new System.Drawing.Size(783, 318);
            this.dgvZahtjevi.TabIndex = 6;
            // 
            // btnPonisti
            // 
            this.btnPonisti.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPonisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPonisti.Location = new System.Drawing.Point(787, 24);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(25, 24);
            this.btnPonisti.TabIndex = 7;
            this.btnPonisti.Text = "X";
            this.btnPonisti.UseVisualStyleBackColor = false;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 57);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrikazZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.dgvZahtjevi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNovi);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.lblKreiraniZahtjevi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrikazZahtjeva";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz kreiranih zahtjeva";
            this.Load += new System.EventHandler(this.FrmPrikazZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKreiraniZahtjevi;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.DataGridView dgvZahtjevi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

