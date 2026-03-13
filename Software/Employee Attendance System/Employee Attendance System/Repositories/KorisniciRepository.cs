using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Attendance_System.Repositories {
    public class KorisniciRepository {
       /// <summary>
       /// Dohvaćanje korisnika iz baze prema korisničkom imenu
       /// </summary>
       /// <param name="username"></param>
       /// <returns></returns>
        public static Korisnici DohvatiKorisnika(string username) {
            string sql = $"SELECT * FROM Korisnici WHERE KorisnickoIme LIKE '{username}'";
            return FetchKorisnika(sql);
        }

        /// <summary>
        /// Dohvaćanje korisnika iz baze prema Id-u
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Korisnici DohvatiKorisnika(int id) {
            string sql = $"SELECT * FROM Korisnici WHERE KorisnickoIme = {id}";
            return FetchKorisnika(sql);
        }

        /// <summary>
        /// Dohvaćanje korisnika iz baze, ako postoji korisnik, stvara se novi objekt u koji se pohranjuju pronađeni podaci
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static Korisnici FetchKorisnika(string sql) {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Korisnici korisnik = null;

            if(reader.HasRows == true) {
                reader.Read();
                korisnik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return korisnik;
        }

        /// <summary>
        /// Stvaranje novog korisnika kao novog objekta klase Korisnici, te spremanje podataka iz baze u odgovarajuća svojstva tog objekta
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static Korisnici CreateObject(SqlDataReader reader) {
            int id = int.Parse(reader["Id"].ToString());
            string korisnickoime = reader["KorisnickoIme"].ToString();
            string lozinka = reader["Lozinka"].ToString();

            var korisnik = new Korisnici {
                Id = id,
                KorisnickoIme = korisnickoime,
                Lozinka = lozinka
            };
            return korisnik;
        }


    }
}
