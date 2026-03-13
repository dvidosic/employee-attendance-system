using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Employee_Attendance_System.Repositories {
    public class ZahtjeviRepository {
        /// <summary>
        /// Dohvaćanje zahtjeva iz baze prema Id-u, ako je zapis pronađen stvara se novi objekt u koji se pohranjuju pronađeni podaci
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Zahtjevi GetZahtjev(int id) {

            Zahtjevi zahtjev = null;

            string sql = $"SELECT * FROM Zahtjevi WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                zahtjev = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zahtjev;

        }

        /// <summary>
        /// Dohvaćanje svih zahtjeva iz baze kako bi se mogli prikazati na DataGridView
        /// </summary>
        /// <returns></returns>
        public static List<Zahtjevi> GetZahtjevi() {

            var zahtjevi = new List<Zahtjevi>();

            string sql = "SELECT * FROM Zahtjevi";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjevi zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;

        }
        /// <summary>
        /// Stvaranje novog zahtjeva kao novog objekta klase Zahtjevi, te spremanje podataka iz baze u odgovarajuća svojstva tog objekta
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Zahtjevi CreateObject(SqlDataReader reader) {

            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            string razlogodsustva = reader["Razlogodsustva"].ToString();
            string vrijemeodsustva = reader["Vrijemeodsustva"].ToString();
            string statuszahtjeva = reader["Statuszahtjeva"].ToString();

            var zahtjev = new Zahtjevi {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                RazlogOdsustva = razlogodsustva,
                VrijemeOdsustva = vrijemeodsustva,
                StatusZahtjeva = statuszahtjeva

            };
            return zahtjev;

        }

           /// <summary>
           /// Brisanje zapisa iz baze
           /// </summary>
           /// <param name="zahtjevi"></param>
           /// <returns></returns>
        public static int Obrisi (Zahtjevi zahtjevi) {
            string sqlDelete = "DELETE FROM Zahtjevi Where Id = " + zahtjevi.Id;
            DB.OpenConnection();
            return DB.ExecuteCommand(sqlDelete);
            DB.CloseConnection();
        }

        /// <summary>
        /// Funkcija koja inserta podatke upisane na FrmStvaranjeZahtjeva u bazu 
        /// </summary>
        /// <param name="zahtjevi"></param>
        /// <returns></returns>
        public static int Spremi(Zahtjevi zahtjevi) {
            string sqlUnos = "";

            sqlUnos = "INSERT INTO Zahtjevi (Ime, Prezime, Razlogodsustva, Vrijemeodsustva, Statuszahtjeva) VALUES ('" + zahtjevi.Ime + "', '" + zahtjevi.Prezime + "','" + zahtjevi.RazlogOdsustva + "','" + zahtjevi.VrijemeOdsustva + "', 'Zaprimljen')";

            DB.OpenConnection();
            return DB.ExecuteCommand(sqlUnos);
            DB.CloseConnection();

        }


        /// <summary>
        /// Funkcija koja mijenja postojeći zapis u bazi ako je on promijenjen na formi FrmIzmjenaZahtjeva
        /// </summary>
        /// <param name="zahtjevi"></param>
        /// <returns></returns>
        public static int Izmijeni (Zahtjevi zahtjevi) {

            string sqlIzmjena = "";

            sqlIzmjena = "UPDATE Zahtjevi SET Ime = '" + zahtjevi.Ime
                      + "', Prezime = '" + zahtjevi.Prezime
                      + "', Razlogodsustva = '" + zahtjevi.RazlogOdsustva
                      + "', Vrijemeodsustva = '" + zahtjevi.VrijemeOdsustva
                      + "' WHERE Id = " + zahtjevi.Id;

            DB.OpenConnection();
            return DB.ExecuteCommand(sqlIzmjena);
            DB.CloseConnection();

        }




        /// <summary>
        /// Funkcija koja vraća one zahtjeve koji imaju status "Odobren"
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static List<Zahtjevi> GetZahtjeviByStatus(string status) {
            var zahtjevi = new List<Zahtjevi>();

            string sql = $"SELECT * FROM Zahtjevi WHERE Statuszahtjeva LIKE 'Odobren'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjevi zahtjev = CreateObject(reader);
                zahtjevi.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return zahtjevi;
        }






        }
}
