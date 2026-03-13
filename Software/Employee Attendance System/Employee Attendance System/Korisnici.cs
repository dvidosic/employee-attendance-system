using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Attendance_System {

    /// <summary>
    /// Model koji služi za pohranjivanje podataka iz baze
    /// </summary>
    public class Korisnici {

        public int Id { get; set; }
        public string KorisnickoIme { get; set; }

        public string Lozinka { get; set; }

        /// <summary>
        /// Funkcija koja provjerava je li prosljeđena lozinka jednaka dohvaćenoj lozinci iz baze (u varijablu Lozinka)
        /// </summary>
        /// <param name="lozinka"></param>
        /// <returns></returns>
        public bool ProvjeriLozinku(string lozinka) {
            return Lozinka == lozinka;
        }
        
    }
}
