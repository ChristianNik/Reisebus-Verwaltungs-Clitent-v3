using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReisebusVerwaltung_Clitent_v0._3.formen.dialog
{
    public class Buchung
    {
        private int buchungsID;
        private int benutzerdatenID;
        private int linienID;
        private string vorname;
        private string nachname;
        private int sitzplaetze;
        private int liegesitze;
        private int schlafsitze;
        private string starthaltestelle;
        private string endhaltestelle;
        private DateTime datum;

        public Buchung()
        {
            //leer
        }

        public Buchung(int buchungsID, int benutzerdatenID, int linienID, string vorname, string nachname, int sitzplaetze, int liegesitze, int schlafsitze, string starthaltestelle, string endhaltestelle, DateTime datum)
        {
            this.BuchungsID = buchungsID;
            this.BenutzerdatenID = benutzerdatenID;
            this.LinienID = linienID;
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Sitzplaetze = sitzplaetze;
            this.Liegesitze = liegesitze;
            this.Schlafsitze = schlafsitze;
            this.Starthaltestelle = starthaltestelle;
            this.Endhaltestelle = endhaltestelle;
            this.Datum = datum;
        }

        public int BuchungsID { get => buchungsID; set => buchungsID = value; }
        public int BenutzerdatenID { get => benutzerdatenID; set => benutzerdatenID = value; }
        public int LinienID { get => linienID; set => linienID = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public int Sitzplaetze { get => sitzplaetze; set => sitzplaetze = value; }
        public int Liegesitze { get => liegesitze; set => liegesitze = value; }
        public int Schlafsitze { get => schlafsitze; set => schlafsitze = value; }
        public string Starthaltestelle { get => starthaltestelle; set => starthaltestelle = value; }
        public string Endhaltestelle { get => endhaltestelle; set => endhaltestelle = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}
