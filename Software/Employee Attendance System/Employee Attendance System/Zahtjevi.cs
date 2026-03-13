using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Attendance_System {

    /// <summary>
    /// Model koji služi za pohranjivanje podataka iz baze
    /// </summary>
    public class Zahtjevi {
        public int Id { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string RazlogOdsustva { get; set; }

        public string VrijemeOdsustva { get; set; }

        public string StatusZahtjeva { get; set; }
    }
}
