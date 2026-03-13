using DBLayer;
using Employee_Attendance_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Attendance_System {


    public partial class FrmPrijava : Form {

        public static Korisnici PrijavljeniKorisnik { get; set; }
        public FrmPrijava() {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcija koja služi za provjere unosa korisničkog imena i lozinke. Ako je sve uspješno uneseno otvara se FrmPrikazZahtjeva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrijava_Click(object sender, EventArgs e) {

            if(txtKorisnickoIme.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtLozinka.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {





                PrijavljeniKorisnik = KorisniciRepository.DohvatiKorisnika(txtKorisnickoIme.Text);

                if(PrijavljeniKorisnik != null && PrijavljeniKorisnik.ProvjeriLozinku(txtLozinka.Text)) {
                    FrmPrikazZahtjeva frmPrikazZahtjeva = new FrmPrikazZahtjeva();
                    Hide();
                    frmPrikazZahtjeva.ShowDialog();
                    Close();
                } else {
                    MessageBox.Show("Pogrešni korisnički podaci!", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }







            

        }

        /// <summary>
        /// Spajanje na bazu podataka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrijava_Load(object sender, EventArgs e) {
            DB.SetConfiguration("IPS23_dvidosic21", "dvidosic21", "Oqis)C&o");
        }
    }
}
