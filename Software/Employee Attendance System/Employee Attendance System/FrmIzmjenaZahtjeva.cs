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
    public partial class FrmIzmjenaZahtjeva : Form {


        private Zahtjevi zahtjev = null;
        public FrmIzmjenaZahtjeva() {
            InitializeComponent();
            
        }

        /// <summary>
        /// Kreiranje novog objekta u koji će se pohraniti postojeći podaci
        /// </summary>
        /// <param name="zahtjevi"></param>
        public FrmIzmjenaZahtjeva(Zahtjevi zahtjevi) {
            InitializeComponent();
            zahtjev = zahtjevi;
        }
        /// <summary>
        /// Zatvaranje forme klikom na gumb "Odustani"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_iz_Click(object sender, EventArgs e) {
            Close();
        }
        /// <summary>
        /// Prikaz postojećeg zahtjeva prilikom otvaranja forme kako bi se podaci mogli uređivati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIzmjenaZahtjeva_Load(object sender, EventArgs e) {

            txtRbr_iz.Text = zahtjev.Id.ToString();
            txtIme_iz.Text = zahtjev.Ime;
            txtPrezime_iz.Text = zahtjev.Prezime;
            txtRazlog_iz.Text = zahtjev.RazlogOdsustva;
            txtVrijeme_iz.Text = zahtjev.VrijemeOdsustva;
            txtStatus_iz.Text = zahtjev.StatusZahtjeva;
            
        }
        /// <summary>
        /// Poziva se funkcija za izmjenu koja će napraviti update zahtjeva koji je promijenjen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpremi_iz_Click(object sender, EventArgs e) {

            zahtjev.Ime = txtIme_iz.Text;
            zahtjev.Prezime = txtPrezime_iz.Text;
            zahtjev.RazlogOdsustva = txtRazlog_iz.Text;
            zahtjev.VrijemeOdsustva = txtVrijeme_iz.Text;
            ZahtjeviRepository.Izmijeni(zahtjev);
            this.Close();
                
        }
    }
}
