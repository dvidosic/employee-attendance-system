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
    public partial class FrmStvaranjeZahtjeva : Form {

        private Zahtjevi zahtjev = null;

        public FrmStvaranjeZahtjeva() {
            InitializeComponent();
        }


        /// <summary>
        /// Zatvaranje forma klikom na gumb "Odustani"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e) {
            Close();
        }


        /// <summary>
        /// Klikom na gumb "Spremi" poziva se funkcija za spremanje koja pohranjuje unesene podatke u bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_Click(object sender, EventArgs e) {
            zahtjev = new Zahtjevi();
            zahtjev.Ime = txtIme.Text;
            zahtjev.Prezime = txtPrezime.Text;
            zahtjev.RazlogOdsustva = txtRazlog.Text;
            zahtjev.VrijemeOdsustva = txtVrijeme.Text;
            ZahtjeviRepository.Spremi(zahtjev);
            this.Close();
            


        }
    }
}
