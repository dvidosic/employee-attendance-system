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

namespace Employee_Attendance_System
{
    public partial class FrmPrikazZahtjeva : Form
    {
        public FrmPrikazZahtjeva()
        {
            InitializeComponent();
           
        }

        /// <summary>
        /// Poziva se nakon promjene nad bazom, kako bi se prikazalo trenutno stanje u bazi predanih zahtjeva
        /// </summary>
        private void RefreshZahtjeva() {
            List<Zahtjevi> listaZahtjeva = ZahtjeviRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = listaZahtjeva;
        }

        /// <summary>
        /// Otvara se (kreira) nova instanca klase FrmStvaranjeZahtjeva, kako bi se mogao kreirati novi zahtjev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovi_Click(object sender, EventArgs e) {
            FrmStvaranjeZahtjeva frmStvaranjeZahtjeva = new FrmStvaranjeZahtjeva();
            frmStvaranjeZahtjeva.ShowDialog();
            RefreshZahtjeva();
        }
        

        /// <summary>
        /// Spajanje na bazu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrikazZahtjeva_Load(object sender, EventArgs e) {
            DB.SetConfiguration("IPS23_dvidosic21", "dvidosic21", "Oqis)C&o");
            ShowZahtjevi();
            
        }

        /// <summary>
        /// Dohvaćanje podataka o zahtjevima i postavljanje kao izvora za DataGridView
        /// </summary>
        private void ShowZahtjevi() {
            var zahtjevi = ZahtjeviRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;


            dgvZahtjevi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvZahtjevi.Columns["Id"].DisplayIndex = 0;
            dgvZahtjevi.Columns["Ime"].DisplayIndex = 1;
            dgvZahtjevi.Columns["Prezime"].DisplayIndex = 2;
            dgvZahtjevi.Columns["RazlogOdsustva"].DisplayIndex = 3;
            dgvZahtjevi.Columns["VrijemeOdsustva"].DisplayIndex = 4;
            dgvZahtjevi.Columns["StatusZahtjeva"].DisplayIndex = 5;


            foreach (DataGridViewColumn column in dgvZahtjevi.Columns) {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
        /// <summary>
        /// Funkcija za brisanje zahtjeva iz baze (onoga koji je odabran trenutno). Poziva se metoda za brisanje koja sadrži sql upit za brisanje te se podaci osvježavaju.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisi_Click(object sender, EventArgs e) {
            Zahtjevi odabraniZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjevi;

            ZahtjeviRepository.Obrisi(odabraniZahtjev);
            RefreshZahtjeva();
            

        }
        /// <summary>
        /// Otvara se (kreira) nova instanca klase FrmIzmjenaZahtjeva. Dohvaćaju se podaci jednog retka (zahtjeva) kako bi se mogli izmijeniti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzmijeni_Click(object sender, EventArgs e) {

            Zahtjevi odabraniZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjevi;

            FrmIzmjenaZahtjeva frmIzmjenaZahtjeva = new FrmIzmjenaZahtjeva(odabraniZahtjev);
            frmIzmjenaZahtjeva.ShowDialog();
            RefreshZahtjeva();
        }
        /// <summary>
        /// Funkcija za pretraživanje zahtjeva prema unesenom tekstu. Kao izvor DataGridViewa postavljaju se oni zahtjevi koji odgovaraju upisanom statusu (Odobren)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPretrazivanje_TextChanged(object sender, EventArgs e) {

            string searchText = txtPretrazivanje.Text.Trim(); 
            List<Zahtjevi> searchResults = ZahtjeviRepository.GetZahtjeviByStatus(searchText); 
            dgvZahtjevi.DataSource = searchResults;

            if(txtPretrazivanje.Text == "") {
                RefreshZahtjeva();
            }
        }
        /// <summary>
        /// Funkcija gumba koja služi kako bi se ispraznio textbox pritiskom na taj gumb
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPonisti_Click(object sender, EventArgs e) {
            txtPretrazivanje.Text = "";
        }
    }
    
}
